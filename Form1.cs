using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstrellaEnForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics papel;
            papel =pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Red);

            int x = 0;
            int pixel = 0;

            //cuadrante1
            while (x <= 25)
            {
              papel.DrawLine(lapiz, (pictureBox1.Width / 2), 0 + pixel, (pictureBox1.Width/2)+10+pixel,pictureBox1.Height/2);
              pixel = pixel + 10;
               x++;
            }

            //cuadrante2
            while (x <= 25)
            {
                papel.DrawLine(lapiz, (pictureBox1.Width / 2), 0 - pixel, (pictureBox1.Width / 2) - 10 + pixel, pictureBox1.Height / 2);
                pixel = pixel + 10;
                x++;
            }


            // cuadrante4
            x = 0;
            pixel = 0;

            while (x <= 25)
            {
                papel.DrawLine(lapiz, (pictureBox1.Width / 2),pictureBox1.Height - pixel,(pictureBox1.Width/2)+10+pixel,pictureBox1.Height/2);
                pixel = pixel + 10;
                x++;
            }

            // cuadrante3
            x = 0;
            pixel = 0;

            while (x <= 25)
            {
                papel.DrawLine(lapiz, (pictureBox1.Width/2), pictureBox1.Height - pixel, (pictureBox1.Width / 2) - 10 - pixel, pictureBox1.Height / 2);
                pixel = pixel + 10;
                x++;
            }

            
           
        }
    }
}
