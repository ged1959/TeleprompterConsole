using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleprompterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = ReadFrom("C:/Users/ged/documents/visual studio 2017/Projects/TeleprompterConsole/TeleprompterConsole/sampleQuotes.txt");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }

        static IEnumerable<string> ReadFrom(string file)
        {
            string line;
            using (var reader = File.OpenText(file))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
    }
}
