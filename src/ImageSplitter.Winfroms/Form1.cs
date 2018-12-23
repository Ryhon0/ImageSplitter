using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageSplitter;

namespace SplitterGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gen.Enabled = false;
            genprev.Enabled = false;
            ssize.Enabled = false;
        }

        Image src;

        //Open file
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) file.Text = openFileDialog1.FileName;
        }

        //Open folder
        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) path.Text = folderBrowserDialog1.SelectedPath;
        }

        //Set image
        private void file_TextChanged(object sender, EventArgs e)
        {
            try
            {
                src = Image.FromFile(file.Text);
                preview.Image = src;
                dimensions.Text = "Dimensions: " + src.Width + "x" + src.Height;
                if (src.GetFrameCount(new FrameDimension(src.FrameDimensionsList[0])) > 1) animated.Text = "Is Animated: True - Only the first frame will be saved";
                else animated.Text = "Is Animated: False";
                ssize.Enabled = true;
                string size = ssize.Text;
                ssize.Text = "";
                ssize.Text = size;
            }
            catch
            {
                src = new Bitmap(1,1);
                preview.Image = src;
                dimensions.Text = "Dimensions: ";
                animated.Text = "Is Animated:";
                gen.Enabled = false;
                genprev.Enabled = false;
                ssize.Text = "";
                ssize.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ImageSplitter.Splitter.Split(src, int.Parse(ssize.Text), path.Text, prefix.Text, surfix.Text);
        }

        private void ssize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                columns.Text = Math.Ceiling((decimal)src.Width / int.Parse(ssize.Text)).ToString();
                rows.Text = Math.Ceiling((decimal)src.Height / int.Parse(ssize.Text)).ToString();
                total.Text = "Total : " + Math.Ceiling((decimal)src.Width / int.Parse(ssize.Text)) * Math.Ceiling((decimal)src.Height / int.Parse(ssize.Text));
                genprev.Enabled = true;
                gen.Enabled = true;
            }
            catch
            {
                columns.Text = "";
                rows.Text = "";
                total.Text = "Total:";
                gen.Enabled = false;
                genprev.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            preview.Image = ImageSplitter.Splitter.GeneratePreview(src, int.Parse(ssize.Text), int.Parse(columns.Text), int.Parse(rows.Text));
        }

        private void prefix_surfix_TextChanged(object sender, EventArgs e)
        {
            emotename.Text = "Example emote name: " + prefix.Text + "XX" + surfix.Text;
        }
    }
}