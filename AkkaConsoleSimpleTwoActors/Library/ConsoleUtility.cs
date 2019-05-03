using System;

namespace AkkaConsoleSimpleTwoActorsCall.Library
{
    public static class ConsoleUtility
    {
        private static readonly object _sync = new object();

        public static void PrintMsg(string message, bool success = true)
        {
            var foreGroundColor = (success) ? ConsoleColor.Green : ConsoleColor.Red;
            lock (_sync)
            {
                Console.ForegroundColor = foreGroundColor;
                Console.WriteLine($"{DateTime.Now:o} => {message}");
            }
        }
    }
}
