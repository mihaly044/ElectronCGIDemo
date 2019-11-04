using System;
using ElectronCgi.DotNet;

namespace ElectronCGIDemo
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var connection = new ConnectionBuilder()
                .WithLogging()
                .Build();

            // expects a request named "greeting" with a string argument and returns a string
            connection.On<string, string>("greeting", name => "Hello " + name);

            // wait for incoming requests
            connection.Listen();        
        }
    }
}