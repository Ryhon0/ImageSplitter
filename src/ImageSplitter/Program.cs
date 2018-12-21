using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageSplitter
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the file path");
            string file = Console.ReadLine();
            Console.WriteLine("Enter the output folder path");
            string output = Console.ReadLine();
            Console.WriteLine("Generating emojis, please wait");
            Splitter.Split(Image.FromFile(file), 128, output);
            Console.WriteLine("Done! Press any key to close");
            Console.ReadKey();
        }
    }
}