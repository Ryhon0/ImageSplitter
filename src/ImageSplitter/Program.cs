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

            Image img = Image.FromFile(file);

            if ((img.GetFrameCount(new FrameDimension(img.FrameDimensionsList[0])) > 1))
            {
                int? delay = null;
                while (delay == null)
                {
                    try
                    {
                        Console.WriteLine("Enter the delay between frames");
                        delay = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Failed to parse the delay");
                    }
                }
                Console.WriteLine("Generating emojis, please wait...");
                Splitter.SplitGif(img, (int)size, output, prefix, suffix, true, (int)delay);
            }
            else
            {
                Console.WriteLine("Generating emojis, please wait...");
                Splitter.Split(img, (int)size, output, prefix, suffix, true);
            }

            Console.WriteLine("Done! Press any key to close");
            Console.ReadKey();
        }
    }
}