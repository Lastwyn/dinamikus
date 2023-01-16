using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinamikus
{
    public partial class Form1 : Form
    {
         
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                for (int j = 0; j < numericUpDown2.Value; j++)
                {
                    int temp = Convert.ToInt32(numericUpDown3.Value);
                    PictureBox picturebox = new PictureBox();
                    picturebox.ImageLocation = "..//../pictures/easter-bunny.png";
                    picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picturebox.SetBounds(j * temp, i * temp, temp, temp);
                    picturebox.Click += (o, ev) => {
                        PictureBox picture = (PictureBox)o;
                        picture.ImageLocation = "..//../pictures/candle.png";

                    };
                    panel1.Controls.Add(picturebox);
                }
            }
        }
    }
}
