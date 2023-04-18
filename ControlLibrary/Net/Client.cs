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
        private Socket client;

        public Client()
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public async Task ConnectToController(IPEndPoint remoteEP)
        {
            await ConnectAsync(remoteEP);

            Task receive = Task.Run(() => ReceiveAndProcessasync());

            await Task.WhenAll(receive);
        }

        private async Task ConnectAsync(IPEndPoint remoteEP)
        {
            try
            {
                await client.ConnectAsync(remoteEP);
            }
            catch
            {
                // TODO - Handle connection exceptions
            }
        }

        private async Task ReceiveAndProcessasync()
        {
            Pipe pipe = new Pipe();
            Task receiving = ReceiveAsync(pipe.Writer);
            Task processing = ProcessAsync(pipe.Reader);

            await Task.WhenAll(receiving, processing);
        }

        private async Task ReceiveAsync(PipeWriter writer)
        {
            // TODO - Add CancellationToken to end async receive

            // TODO - Lookup max message size and set appropriate buffer size
            // TODO - Setup better const variable, possible global if necessary
            const int bufferSize = 1024;

            while (true)
            {
                Memory<byte> memory = writer.GetMemory(bufferSize);

                try
                {
                    int bytesRead = await client.ReceiveAsync(memory, SocketFlags.None);
                    if (bytesRead == 0)
                    {
                        break;
                    }

                    writer.Advance(bytesRead);
                }
                catch
                {
                    // TODO - Handle receive exceptions
                }

                FlushResult result = new FlushResult();
                if (result.IsCompleted)
                {
                    break;
                }
            }

            await writer.CompleteAsync();
        }

        private async Task ProcessAsync(PipeReader reader)
        {
            while (true)
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

        public async Task SendAsync()
        {
            // TODO - Need to create message model before logic to send message
            throw new NotImplementedException();
        }
    }
}
