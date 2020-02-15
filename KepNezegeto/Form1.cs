using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KepNezegeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelUserName.Text = Environment.UserName;
        }

        private void buttonMegjelenites_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void buttonHatter_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;                
            }
        }

        private void buttonBezaras_Click(object sender, EventArgs e)
        {
            //Jelenlegi formot bezárja
            //this.Close();
            //Teljes alkalmazást bezárja
            Application.Exit();
            //Kliens gépen zárja be az alkalmazást
            //Environment.Exit(0);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
