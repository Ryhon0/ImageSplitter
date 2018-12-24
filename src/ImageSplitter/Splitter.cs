using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace ImageSplitter
{
    public class Splitter
    {
        public static void Split(Image src, int size, string OutputLocation, string prefix, string surfix, bool downscale = true)
        {
            Image tile = new Bitmap(size, size);

            Size emotesize = new Size(128, 128);
            if (!downscale) emotesize = new Size(size, size);

            int columns = (int)Math.Ceiling((decimal)src.Width / tile.Width);
            int rows = (int)Math.Ceiling((decimal)src.Height / tile.Height);

            Bitmap image = new Bitmap(columns * tile.Width, rows * tile.Height);

            using (Graphics g = Graphics.FromImage(image))
            {
                g.Clear(System.Drawing.Color.Transparent);
                g.SetClip(new Rectangle(0, 0, columns * tile.Width, rows * tile.Height));
                g.DrawImage(src, 0, 0, src.Width, src.Height);
            }

            int column = 0;
            int row = 0;
            string emotetext = "";
            for (int i = 0; i < columns * rows; i++)
            {
                new Bitmap(image.Clone(new Rectangle(column * tile.Width, row * tile.Height, tile.Width, tile.Height), image.PixelFormat), emotesize).Save(OutputLocation + "/" + prefix + i.ToString("D2").Replace("100", "100~1").Replace("1234", "1234~1") + surfix + ".jpg");
                emotetext += ":" + prefix + i.ToString("D2").Replace("100", "100~1").Replace("1234", "1234~1") + surfix + ":";
                if (column == columns - 1)
                {
                    column = 0;
                    row++;
                    emotetext += Environment.NewLine;
                }
                else column++;
            }
            File.WriteAllLines(OutputLocation + "/emotes.txt", emotetext.Split(new[] { Environment.NewLine }, StringSplitOptions.None));
        }

        public static void SplitGif(Image src, int size, string Output, string prefix, string suffix, bool downscale, int delay)
        {
            Image[] frames = getFrames(src);
            int rows = (int)Math.Ceiling((decimal)src.Width / size);
            int columns = (int)Math.Ceiling((decimal)src.Height / size);

            for (int i = 0; i < frames.Length; i++) //generate emotes for each frame
            {
                Split(frames[i], size, Path.GetTempPath() + "ImageSplitter/gif" + i, prefix, suffix, downscale);
            }

            for (int i = 0; i < columns * rows; i++) // for every emote set make a gif
            {
                string emote = Output + "/" + prefix + i.ToString("D2") + suffix + ".gif";
                string images = "";

                for (int ii = 0; ii < frames.Length; ii++) // get all the emote paths
                {
                    Image.FromFile(Path.GetTempPath() + "ImageSplitter/gif" + ii + "/" + prefix + i.ToString("D2") + suffix + ".jpg").Save(Path.GetTempPath() + "ImageSplitter/gif" + ii + "/" + prefix + i.ToString("D2") + suffix + ".gif", ImageFormat.Gif);

                    images += " " + Path.GetTempPath() + "ImageSplitter/gif" + ii + "/" + prefix + i.ToString("D2") + suffix + ".gif";
                }

                Process p = new Process();
                p.StartInfo.FileName = "gifsicle.exe";
                p.StartInfo.Arguments = $"--delay={delay/10} -O1 --colors=64 --loopcount=forever {images} -o {emote}";
                p.StartInfo.UseShellExecute = false;
                p.Start();
            }
            File.Copy(Path.GetTempPath() + "ImageSplitter/gif" + 0 + "/emotes.txt", Output + "/emotes.txt");
        }

        public static Image GeneratePreview(Image src, int size, int columns, int rows)
        {
            Image img = new Bitmap(size * columns, size * rows);

            using (Graphics g = Graphics.FromImage(img))
            {
                g.DrawImage(src, 0, 0, src.Width, src.Height);
            }

            bool rowStartWithRed = true;

            for (int ir = 0; ir < rows; ir++)
            {
                bool red = rowStartWithRed;
                for (int ic = 0; ic < columns; ic++)
                {
                    Brush b = new SolidBrush(Color.FromArgb(64, 255, 0, 0));
                    if (!red) b = new SolidBrush(Color.FromArgb(64, 0, 0, 255));

                    Rectangle rect = new Rectangle(ic * size, ir * size, size, size);

                    using (Graphics g = Graphics.FromImage(img))
                    {
                        g.FillRectangle(b, rect);
                    }
                    red = !red;
                }
                rowStartWithRed = !rowStartWithRed;
            }
            return img;
        }

        public static Image GenerateGifPreview(Image src, int size, int columns, int rows, int delay)
        {
            Image[] frames = getFrames(src);

            string images = "";

            for (int i = 0; i < frames.Length; i++) //generate preview for each frame
            {
                Directory.CreateDirectory(Path.GetTempPath() + "ImageSplitter/gifpreview/");
                GeneratePreview(frames[i], size, columns, rows).Save(Path.GetTempPath() + "ImageSplitter/gifpreview/" + i.ToString("D2") + ".gif", ImageFormat.Gif);
                images += " " + Path.GetTempPath() + "ImageSplitter/gifpreview/" + i.ToString("D2") + ".gif";
            }

            var randomNumber = DateTime.Now.Ticks;

            Process p = new Process();
            p.StartInfo.FileName = "gifsicle.exe";
            p.StartInfo.Arguments = $"--delay={delay / 10} -O1 --colors=16 --loopcount=forever {images} -o {Path.GetTempPath() + "ImageSplitter/gifpreview" + randomNumber + ".gif"}";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();
            Console.WriteLine(p.StandardError.ReadToEnd());

            return Image.FromFile(Path.GetTempPath() + "ImageSplitter/gifpreview" + randomNumber + ".gif");
        }

        private static Image[] getFrames(Image originalImg)
        {
            int numberOfFrames = originalImg.GetFrameCount(FrameDimension.Time);
            Image[] frames = new Image[numberOfFrames];

            for (int i = 0; i < numberOfFrames; i++)
            {
                originalImg.SelectActiveFrame(FrameDimension.Time, i);
                frames[i] = ((Image)originalImg.Clone());
            }

            return frames;
        }
    }
}
