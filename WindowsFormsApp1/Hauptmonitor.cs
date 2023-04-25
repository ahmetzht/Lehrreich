using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Hauptmonitor : Form
    {
        public Hauptmonitor()
        {
            InitializeComponent();

        }

        Graphics cizim;

       // Point ;

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked || checkBox6.Checked)
            //{
            //     button7.Enabled = true;
            //}
            // else
            //{
            //   button7.Enabled = false;
            //}
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked && checkBox6.Checked && checkBox7.Checked && checkBox8.Checked && checkBox9.Checked && checkBox13.Checked)
            {
                Video videosec = new Video();
                videosec.Show();
                this.Hide();
            }
            else if (checkBox1.Checked && checkBox2.Checked && checkBox4.Checked && checkBox5.Checked && checkBox10.Checked && checkBox11.Checked && checkBox12.Checked && checkBox14.Checked && checkBox15.Checked)
            {
                MessageBox.Show("Versuchen Sie es erneut");
            }
            else
                MessageBox.Show("Versuchen Sie es erneut");


            //        {
            //              if (checkBox1.Checked == true & amp; &amp; checkBox2.Checked == false & amp; &amp; checkBox3.Checked == false)
            //{ label1.Text = ""; }
            //else if (checkBox1.Checked == false & amp; &amp; checkBox2.Checked == true & amp; &amp; checkBox3.Checked == false)
            //{ label1.Text = ""; }

            // If(CheckBox1.Checked == True)
            // Button1.Enabled = True
            //Else
            //  Button1.Enabled = False

            //pictureBox1.BackColor = Color.Silver;
            //pictureBox1.Refresh();

            //cizim = pictureBox1.CreateGraphics();
            //cizim.Clear(Color.Silver);
            //cizim.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Geprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Black, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - 400, y - 215, 150, 150);
                cizim.Dispose();
            }
            else
            {
                checkBox1.Text = "Ungeprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Silver, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - 400, y - 215, 150, 150);
                cizim.Dispose();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Text = "Geprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Black, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - 248, y - 215, 150, 150);
                cizim.Dispose();
            }
            else
            {
                checkBox2.Text = "Ungeprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Silver, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - 248, y - 215, 150, 150);
                cizim.Dispose();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox3.Text = "Geprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Black, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - 96, y - 215, 150, 150);
                cizim.Dispose();
            }
            else
            {
                checkBox3.Text = "Ungeprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Silver, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - 96, y - 215, 150, 150);
                cizim.Dispose();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox4.Text = "Geprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Black, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - -56, y - 215, 150, 150);
                cizim.Dispose();
            }
            else
            {
                checkBox4.Text = "Ungeprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Silver, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - -56, y - 215, 150, 150);
                cizim.Dispose();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox5.Text = "Geprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Black, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - -208, y - 215, 150, 150);
                cizim.Dispose();
            }
            else
            {
                checkBox5.Text = "Ungeprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Silver, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - -208, y - 215, 150, 150);
                cizim.Dispose();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox6.Text = "Geprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Black, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - 400, y - 63, 150, 150);
                cizim.Dispose();
            }
            else
            {
                checkBox6.Text = "Ungeprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Silver, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - 400, y - 63, 150, 150);
                cizim.Dispose();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox7.Text = "Geprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Black, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - 248, y - 63, 150, 150);
                cizim.Dispose();
            }
            else
            {
                checkBox7.Text = "Ungeprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Silver, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - 248, y - 63, 150, 150);
                cizim.Dispose();
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox8.Checked)
            {
                checkBox8.Text = "Geprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Black, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - 96, y - 63, 150, 150);
                cizim.Dispose();
            }
            else
            {
                checkBox8.Text = "Ungeprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Silver, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - 96, y - 63, 150, 150);
                cizim.Dispose();
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                checkBox9.Text = "Geprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Black, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - -56, y - 63, 150, 150);
                cizim.Dispose();
            }
            else
            {
                checkBox9.Text = "Ungeprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Silver, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - -56, y - 63, 150, 150);
                cizim.Dispose();
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                checkBox10.Text = "Geprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Black, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - -208, y - 63, 150, 150);
                cizim.Dispose();
            }
            else
            {
                checkBox10.Text = "Ungeprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Silver, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - -208, y - 63, 150, 150);
                cizim.Dispose();
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                checkBox11.Text = "Geprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Black, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - 400, y - -89, 150, 150);
                cizim.Dispose();
            }
            else
            {
                checkBox11.Text = "Ungeprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Silver, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - 400, y - -89, 150, 150);
                cizim.Dispose();
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                checkBox12.Text = "Geprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Black, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - 248, y - -89, 150, 150);
                cizim.Dispose();
            }
            else
            {
                checkBox12.Text = "Ungeprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Silver, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - 248, y - -89, 150, 150);
                cizim.Dispose();
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                checkBox13.Text = "Geprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Black, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - 96, y - -89, 150, 150);
                cizim.Dispose();
            }
            else
            {
                checkBox13.Text = "Ungeprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Silver, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - 96, y - -89, 150, 150);
                cizim.Dispose();
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                checkBox14.Text = "Geprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Black, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - -56, y - -89, 150, 150);
                cizim.Dispose();
            }
            else
            {
                checkBox14.Text = "Ungeprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Silver, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - -56, y - -89, 150, 150);
                cizim.Dispose();
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                checkBox15.Text = "Geprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Black, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - -208, y - -89, 150, 150);
                cizim.Dispose();
            }
            else
            {
                checkBox15.Text = "Ungeprüft";
                int x = pictureBox1.Width / 2;
                int y = pictureBox1.Height / 2;
                Pen kalem = new Pen(Color.Silver, 3);
                cizim = pictureBox1.CreateGraphics();
                cizim.DrawRectangle(kalem, x - -208, y - -89, 150, 150);
                cizim.Dispose();
            }
        }
    }
}