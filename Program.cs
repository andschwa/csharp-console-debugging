using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] lines =
                {
                    "Normal ASCII text",
                    "你好"
                };

            using (var stream = File.CreateText("Default.log"))
            {
                foreach (var line in lines) { stream.WriteLine(line); }
            }

            var encodings = new Dictionary<String, Encoding>()
                {
                    { "UTF8-Default.log", new UTF8Encoding() },
                    { "ASCII.log", new ASCIIEncoding() },
                    { "UTF8-ExplicitBOM.log", new UTF8Encoding(true) },
                    { "Unicode.log", new UnicodeEncoding() },
                };

            foreach (var encoding in encodings)
            {
                using (var file = new FileStream(encoding.Key, FileMode.Create))
                using (var stream = new StreamWriter(file, encoding.Value))
                {
                    foreach (var line in lines) { stream.WriteLine(line); }
                }
            }
        }
    }
}
