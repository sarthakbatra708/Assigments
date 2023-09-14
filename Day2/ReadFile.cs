using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StreamReader streamReader = new StreamReader(@"C:\FileData\ReadFile.txt", true);
            while (streamReader.EndOfStream == false)
            {
                Console.WriteLine(streamReader.ReadLine());
            }
            streamReader.Close();
            Console.ReadLine();
        }
    }
}
