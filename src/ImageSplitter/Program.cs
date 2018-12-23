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
            Console.WriteLine("Enter the image file path");
            string file = Console.ReadLine();

            int? size = null;
            while (size == null)
            {
                try
                {
                    Console.WriteLine("Enter the emote size");
                    size = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Failed to parse the size");
                }
            }

            Console.WriteLine("Enter the emote prefix");
            string prefix = Console.ReadLine();

            Console.WriteLine("Enter the emote surfix");
            string surfix = Console.ReadLine();

            Console.WriteLine("Enter the output folder path");
            string output = Console.ReadLine();

            Console.WriteLine("Generating emojis, please wait...");
            Splitter.Split(Image.FromFile(file), (int)size, output, prefix, surfix);

            Console.WriteLine("Done! Press any key to close");
            Console.ReadKey();
        }
    }
}