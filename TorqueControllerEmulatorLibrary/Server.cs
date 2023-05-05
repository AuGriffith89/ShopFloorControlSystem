using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace TorqueControllerEmulatorLibrary
{
    public class Server
    {
        private Socket _server;

        public Server()
        {
            _server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public async Task StartListening(IPEndPoint localEP)
        {
            _server.Bind(localEP);
            _server.Listen();

            await _server.AcceptAsync();

            await ReceiveAndProcessAsync();
        }

        private async Task ReceiveAndProcessAsync()
        {
            Pipe pipe = new Pipe();
            Task receiving = Task.Run(() => ReceiveAsync(pipe.Writer));
            Task processing = Task.Run(() => ProcessAsync(pipe.Reader));

            await Task.WhenAll(receiving, processing);
        }

        private async Task ReceiveAsync(PipeWriter writer)
        {
            const int bufferSize = 1024;

            while (true)
            {
                Memory<byte> memory = writer.GetMemory(bufferSize);

                try
                {
                    int bytesRead = await _server.ReceiveAsync(memory, SocketFlags.None);
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
            // Need to make sure first message received is Communication Start
            //  - All other messages are to be ignored until this one received
            throw new NotImplementedException();
        }
    }
}
