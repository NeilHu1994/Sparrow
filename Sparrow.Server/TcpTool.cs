using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Sparrow.Server {
    public class TcpTool {
        private TcpListener listener;
        private TcpClient client;
        private NetworkStream netStream;
        private const int portNum = 5678;
        private const string hostName = "localhost";
        public TcpTool() {
            Init();
        }
        private void Init() {
            listener = new TcpListener(IPAddress.Any, portNum);
        }
        public void Start() {
            Lister();
            ParseRequestStr();
            WriteToEnd();
        }

        private void Lister() {
            listener.Start();
            client = listener.AcceptTcpClient();
            netStream = client.GetStream();

        }

        private void ParseRequestStr() {
            byte[] bytes = new byte[1024];
            int bytesRead = netStream.Read(bytes, 0, bytes.Length);
            Console.WriteLine(Encoding.ASCII.GetString(bytes, 0, bytesRead));
        }

        private void WriteToEnd() {
            byte[] byteTime = Encoding.ASCII.GetBytes(DateTime.Now.ToString());
            try {
                netStream.Write(byteTime, 0, byteTime.Length);
                netStream.Close();
                client.Close();
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            listener.Stop();
        }
    }
}
