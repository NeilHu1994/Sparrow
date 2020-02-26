using Sparrow.Server;
using System;

namespace Sparrow.Host {
    public class SelfHost {
        public static void ManageServer() {
            HttpServer.Start();
        }
    }
}
