using ControlLibrary.Models.Messages;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary.Net
{
    public class Client
    {
        private Socket _client;

        public EventHandler<MessageModel>? ReceviedTighteningEvent;

        private CancellationTokenSource _cancellationTokenSource;

        public Client()
        {
            _client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _cancellationTokenSource = new CancellationTokenSource();
        }

        public async Task ConnectToController(IPEndPoint remoteEP)
        {
            try
            {
                await _client.ConnectAsync(remoteEP);

                Pipe pipe = new Pipe();
                Task receiving = Task.Run(() => ReceiveAsync(pipe.Writer));
                Task processing = Task.Run(() => ProcessAsync(pipe.Reader));

                await Task.WhenAll(receiving, processing);
            }
            catch (OperationCanceledException) { }
            catch (Exception)
            {
                _cancellationTokenSource.Cancel();
                throw;
            }
            finally
            {
                CloseSocket();
            }
        }

        private async Task ReceiveAsync(PipeWriter writer)
        {
            // TODO - Setup better const variable, possible global if necessary
            const int bufferSize = 1024;
            CancellationToken token = _cancellationTokenSource.Token;

            try
            {
                while (!token.IsCancellationRequested)
                {
                    Memory<byte> memory = writer.GetMemory(bufferSize);
                    int bytesRead = await _client.ReceiveAsync(memory, SocketFlags.None);
                    if (bytesRead == 0)
                    {
                        break;
                    }

                    writer.Advance(bytesRead);

                    await writer.FlushAsync();
                }
            }
            catch (OperationCanceledException) { }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                await writer.CompleteAsync();
            }
        }

        private async Task ProcessAsync(PipeReader reader)
        {
            while (!_cancellationTokenSource.IsCancellationRequested)
            {
                ReadResult result = await reader.ReadAsync();
                ReadOnlySequence<byte> buffer = result.Buffer;

                while (TryReadMessage(ref buffer, out ReadOnlySequence<byte> message))
                {
                    ProcessMessage(message);
                }

                reader.AdvanceTo(buffer.Start, buffer.End);

                if (result.IsCompleted)
                {
                    break;
                }
            }

            await reader.CompleteAsync();
        }

        private bool TryReadMessage(ref ReadOnlySequence<byte> buffer, out ReadOnlySequence<byte> message)
        {
            // TODO - Setup better const variable for null byte, possible global if necessary
            SequencePosition? position = buffer.PositionOf((byte)'\0');

            if (position == null)
            {
                message = default;
                return false;
            }

            message = buffer.Slice(0, position.Value);
            buffer = buffer.Slice(buffer.GetPosition(1, position.Value));

            return true;
        }

        private void ProcessMessage(ReadOnlySequence<byte> message)
        {
            // TODO - Logic for processing messages
            throw new NotImplementedException();
        }

        public async Task SendAsync(MessageModel message)
        {
            byte[] byteData = message.Build();

            await _client.SendAsync(byteData, SocketFlags.None);
        }

        private void CloseSocket()
        {
            if (_client.Connected)
            {
                _client.Shutdown(SocketShutdown.Both);
            }

            _client.Close();
        }
    }
}
