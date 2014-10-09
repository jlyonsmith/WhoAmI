using System;
using System.Threading;
using ServiceStack.Logging;

namespace ﻿﻿WhoAmIService
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager.LogFactory = new ConsoleLogFactory();

            var appHost = new AppHost();
            appHost.Init();
            appHost.Start("http://*:2012/");

            Console.WriteLine("\n\nListening on http://*:2012/..");
            Console.WriteLine("Type Ctrl+C to quit..");
            Thread.Sleep(System.Threading.Timeout.Infinite);
        }
    }
}