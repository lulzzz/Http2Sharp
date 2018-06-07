﻿namespace Http2Sharp.Cli
{
    internal static class Program
    {
        private static void Main()
        {
            using (var server = new HttpServer<TestServer>())
            {
                server.Port = 8080;
                server.StartListen().Wait();
            }
        }
    }
}