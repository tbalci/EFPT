using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPT.Remote
{
   public class PipeClient
    {
        public void Send(string SendStr, string PipeName, int TimeOut = 100000)
        {
            try
            {
                NamedPipeClientStream pipeStream = new NamedPipeClientStream(".", PipeName, PipeDirection.Out, PipeOptions.Asynchronous);
                pipeStream.Connect(TimeOut);
                // Debug.WriteLine("[Client] Pipe connection established");
                byte[] _buffer = Encoding.UTF8.GetBytes(SendStr);
                pipeStream.BeginWrite(_buffer, 0, _buffer.Length, AsyncSend, pipeStream);
            }
            catch (TimeoutException oEX)
            {
                // Debug.WriteLine(oEX.Message);
            }
        }

        private void AsyncSend(IAsyncResult iar)
        {
            try
            {
                NamedPipeClientStream pipeStream = (NamedPipeClientStream)iar.AsyncState;
                pipeStream.EndWrite(iar);
                pipeStream.Flush();
                pipeStream.Close();
                pipeStream.Dispose();
            }
            catch (Exception oEX)
            {
                Debug.WriteLine(oEX.Message);
            }
        }
    }
}
