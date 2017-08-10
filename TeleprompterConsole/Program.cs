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


            //IEnumerableをListに変換。
            var lines2 = new List<string>();
            lines2 = lines.ToList();
            lines2.Add("This is the end of lines2.");// 行を足せる！

            for (var i = 0; i < 10; i++)
                Console.WriteLine($"{i}     " + lines2[i]);
            Console.WriteLine("Enter Key please.");
            Console.ReadLine();


            foreach (var line in lines2)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("Enter Key please.");
            Console.ReadLine();
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
