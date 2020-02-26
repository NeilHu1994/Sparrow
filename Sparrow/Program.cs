using Sparrow.Host;
using System;

namespace sparrow {
    class Program {
        static void Main(string[] args) {
            SelfHost.ManageServer();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
