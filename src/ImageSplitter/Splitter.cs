using System;
using System.Collections.Generic;
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
    }
}
