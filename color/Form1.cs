using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Imaging;
using AForge.Imaging.Formats;
using AForge.Imaging.Filters;
using System.Diagnostics;
using System.Drawing.Imaging;
using AForge.Math;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Bitmap imgLoad, imgtwo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imgLoad = ImageDecoder.DecodeFromFile(@"Nut0.png");
            pictureBox1.Image = imgLoad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imgtwo = new Bitmap(imgLoad);
            for (int i = 0; i < imgtwo.Width; i++)
            {
                for (int j = 0; j < imgtwo.Height; j++)
                {
                    Color myColor = Color.FromArgb(255, i, j);
                    imgtwo.SetPixel(i, j, myColor);
                }
                pictureBox1.Image = imgtwo;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = @"imgtwo.jpg";
            saveFileDialog1.Filter = "Bitmap file (*.jpg)|*.jpg";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }

        }
    }
}
