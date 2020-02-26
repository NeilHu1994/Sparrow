using System;

namespace Sparrow.Server {
    public class HttpServer {
        public static void Start() {
            var tool = new TcpTool();
            tool.Start();
        }
    }
}
