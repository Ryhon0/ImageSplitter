namespace SplitterGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.file = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gen = new System.Windows.Forms.Button();
            this.preview = new System.Windows.Forms.PictureBox();
            this.ssize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rows = new System.Windows.Forms.TextBox();
            this.columns = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.dimensions = new System.Windows.Forms.Label();
            this.animated = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.genprev = new System.Windows.Forms.Button();
            this.prefix = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.suffix = new System.Windows.Forms.TextBox();
            this.emotename = new System.Windows.Forms.Label();
            this.downscale = new System.Windows.Forms.CheckBox();
            this.gif = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.delay = new System.Windows.Forms.TextBox();
            this.savprev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.SuspendLayout();
            // 
            // file
            // 
            this.file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.file.Location = new System.Drawing.Point(103, 12);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(538, 20);
            this.file.TabIndex = 0;
            this.file.Tag = "";
            this.file.TextChanged += new System.EventHandler(this.file_TextChanged);
            // 
            // path
            // 
            this.path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.path.Location = new System.Drawing.Point(103, 38);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(538, 20);
            this.path.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(647, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Explorer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(647, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Explorer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gen
            // 
            this.gen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gen.Enabled = false;
            this.gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gen.Location = new System.Drawing.Point(424, 415);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(282, 99);
            this.gen.TabIndex = 6;
            this.gen.Text = "Generate!";
            this.gen.UseVisualStyleBackColor = true;
            this.gen.Click += new System.EventHandler(this.button3_Click);
            // 
            // preview
            // 
            this.preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preview.BackColor = System.Drawing.Color.Transparent;
            this.preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.preview.Image = ((System.Drawing.Image)(resources.GetObject("preview.Image")));
            this.preview.Location = new System.Drawing.Point(12, 64);
            this.preview.Margin = new System.Windows.Forms.Padding(0);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(407, 450);
            this.preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.preview.TabIndex = 7;
            this.preview.TabStop = false;
            // 
            // ssize
            // 
            this.ssize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ssize.Location = new System.Drawing.Point(496, 157);
            this.ssize.Name = "ssize";
            this.ssize.Size = new System.Drawing.Size(100, 20);
            this.ssize.TabIndex = 8;
            this.ssize.TextChanged += new System.EventHandler(this.ssize_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Path to Image";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Square Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Output Location";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Emote Settings";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Rows";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Columns";
            // 
            // rows
            // 
            this.rows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rows.Enabled = false;
            this.rows.Location = new System.Drawing.Point(496, 209);
            this.rows.Name = "rows";
            this.rows.ReadOnly = true;
            this.rows.Size = new System.Drawing.Size(100, 20);
            this.rows.TabIndex = 18;
            // 
            // columns
            // 
            this.columns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.columns.Enabled = false;
            this.columns.Location = new System.Drawing.Point(496, 183);
            this.columns.Name = "columns";
            this.columns.ReadOnly = true;
            this.columns.Size = new System.Drawing.Size(100, 20);
            this.columns.TabIndex = 17;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(424, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 26);
            this.label8.TabIndex = 21;
            this.label8.Text = "Image Info";
            // 
            // dimensions
            // 
            this.dimensions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dimensions.AutoSize = true;
            this.dimensions.Location = new System.Drawing.Point(426, 90);
            this.dimensions.Name = "dimensions";
            this.dimensions.Size = new System.Drawing.Size(64, 13);
            this.dimensions.TabIndex = 22;
            this.dimensions.Text = "Dimensions:";
            // 
            // animated
            // 
            this.animated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.animated.AutoSize = true;
            this.animated.Location = new System.Drawing.Point(426, 103);
            this.animated.Name = "animated";
            this.animated.Size = new System.Drawing.Size(65, 13);
            this.animated.TabIndex = 23;
            this.animated.Text = "Is Animated:";
            // 
            // total
            // 
            this.total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(494, 232);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(37, 13);
            this.total.TabIndex = 25;
            this.total.Text = "Total :";
            // 
            // genprev
            // 
            this.genprev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.genprev.Enabled = false;
            this.genprev.Location = new System.Drawing.Point(424, 386);
            this.genprev.Name = "genprev";
            this.genprev.Size = new System.Drawing.Size(280, 23);
            this.genprev.TabIndex = 26;
            this.genprev.Text = "Generate Preview";
            this.genprev.UseVisualStyleBackColor = true;
            this.genprev.Click += new System.EventHandler(this.button4_Click);
            // 
            // prefix
            // 
            this.prefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prefix.Location = new System.Drawing.Point(461, 318);
            this.prefix.Name = "prefix";
            this.prefix.Size = new System.Drawing.Size(100, 20);
            this.prefix.TabIndex = 27;
            this.prefix.TextChanged += new System.EventHandler(this.prefix_suffix_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Prefix";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Suffix";
            // 
            // suffix
            // 
            this.suffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.suffix.Location = new System.Drawing.Point(461, 344);
            this.suffix.Name = "suffix";
            this.suffix.Size = new System.Drawing.Size(100, 20);
            this.suffix.TabIndex = 29;
            this.suffix.TextChanged += new System.EventHandler(this.prefix_suffix_TextChanged);
            // 
            // emotename
            // 
            this.emotename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emotename.AutoSize = true;
            this.emotename.Location = new System.Drawing.Point(422, 368);
            this.emotename.Name = "emotename";
            this.emotename.Size = new System.Drawing.Size(128, 13);
            this.emotename.TabIndex = 31;
            this.emotename.Text = "Example emote name: XX";
            // 
            // downscale
            // 
            this.downscale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downscale.AutoSize = true;
            this.downscale.Checked = true;
            this.downscale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.downscale.Location = new System.Drawing.Point(425, 521);
            this.downscale.Name = "downscale";
            this.downscale.Size = new System.Drawing.Size(159, 17);
            this.downscale.TabIndex = 32;
            this.downscale.Text = "Downscale images to 128px";
            this.downscale.UseVisualStyleBackColor = true;
            // 
            // gif
            // 
            this.gif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gif.AutoSize = true;
            this.gif.Location = new System.Drawing.Point(428, 262);
            this.gif.Name = "gif";
            this.gif.Size = new System.Drawing.Size(147, 17);
            this.gif.TabIndex = 33;
            this.gif.Text = "Enable GIF support (slow)";
            this.gif.UseVisualStyleBackColor = true;
            this.gif.CheckedChanged += new System.EventHandler(this.gif_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Delay between frames (ms)";
            // 
            // delay
            // 
            this.delay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delay.Enabled = false;
            this.delay.Location = new System.Drawing.Point(566, 282);
            this.delay.Name = "delay";
            this.delay.Size = new System.Drawing.Size(72, 20);
            this.delay.TabIndex = 35;
            // 
            // savprev
            // 
            this.savprev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savprev.Location = new System.Drawing.Point(12, 517);
            this.savprev.Name = "savprev";
            this.savprev.Size = new System.Drawing.Size(407, 23);
            this.savprev.TabIndex = 41;
            this.savprev.Text = "Save Preview";
            this.savprev.UseVisualStyleBackColor = true;
            this.savprev.Click += new System.EventHandler(this.savprev_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(716, 547);
            this.Controls.Add(this.savprev);
            this.Controls.Add(this.delay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gif);
            this.Controls.Add(this.downscale);
            this.Controls.Add(this.emotename);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.suffix);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.prefix);
            this.Controls.Add(this.genprev);
            this.Controls.Add(this.total);
            this.Controls.Add(this.animated);
            this.Controls.Add(this.dimensions);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rows);
            this.Controls.Add(this.columns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ssize);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.file);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image Splitter";
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox file;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button gen;
        private System.Windows.Forms.PictureBox preview;
        private System.Windows.Forms.TextBox ssize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rows;
        private System.Windows.Forms.TextBox columns;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label dimensions;
        private System.Windows.Forms.Label animated;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button genprev;
        private System.Windows.Forms.TextBox prefix;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox suffix;
        private System.Windows.Forms.Label emotename;
        private System.Windows.Forms.CheckBox downscale;
        private System.Windows.Forms.CheckBox gif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox delay;
        private System.Windows.Forms.Button savprev;
    }
}
