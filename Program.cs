using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] lines = {
                $"BufferHeight: {Console.BufferHeight}",
                $"BufferWidth: {Console.BufferWidth}",
                $"WindowHeight: {Console.WindowHeight}",
                $"WindowWidth: {Console.WindowWidth}",
                $"LargestWindowHeight: {Console.LargestWindowHeight}",
                $"LargestWindowWidth: {Console.LargestWindowWidth}",
                $"IsErrorRedirected: {Console.IsErrorRedirected}",
                $"IsOutputRedirected: {Console.IsOutputRedirected}",
                $"IsInputRedirected: {Console.IsInputRedirected}",
                ""
            };
            foreach (var line in lines) {
                Console.Out.WriteLine(line);
            }
            Console.Error.WriteLine("This is the error stream.");
        }
    }
}
