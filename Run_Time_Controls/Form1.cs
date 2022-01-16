using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Run_Time_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TextBox textBox1 = new TextBox();
            //textBox1.Name = "textBox1";
            //textBox1.Width = 200;
            //textBox1.Height = 75;
            //textBox1.Left = 250;
            //textBox1.Top = 40;

            //this.Controls.Add(textBox1);

            int y1 = 100;
            int y2 = 150;
            int y3 = 200;
            int ind = 140;

            for (char deger = 'A'; deger <= 'I'; deger++)
            {
                Button btn3 = new Button();

                btn3.Text = deger.ToString();
                btn3.Width = 50;
                btn3.Height = 30;
                btn3.Left = ind;
                btn3.Top = y1;

                btn3.Click += Btn3_Click;
                this.Controls.Add(btn3);
                ind += 50;
            }
            ind = 140;

            for (char deger = 'J'; deger <= 'R'; deger++)
            {
                Button btn2 = new Button();

                btn2.Text = deger.ToString();
                btn2.Width = 50;
                btn2.Height = 30;
                btn2.Left = ind;
                btn2.Top = y2;

                btn2.Click += Btn3_Click;
                this.Controls.Add(btn2);
                ind += 50;
            }
            ind = 160;

            for (char deger = 'S'; deger <= 'Z'; deger++)
            {
                Button btn = new Button();


                btn.Text = deger.ToString();
                btn.Width = 50;
                btn.Height = 30;
                btn.Left = ind;
                btn.Top = y3;

                this.Controls.Add(btn);
                btn.Click += Btn3_Click;
                ind += 50;
            }

            Button btn5 = new Button();


            btn5.Text = "Space";
            btn5.Name = "Space";
            btn5.Width = 70;
            btn5.Height = 30;
            btn5.Left = 270;
            btn5.Top = 250;

            this.Controls.Add(btn5);
            btn5.Click += Btn5_Click;

            Button btn4 = new Button();

            btn4.Text = "Sil";
            btn4.Name = "Sil";
            btn4.Width = 50;
            btn4.Height = 30;
            btn4.Left = 400;
            btn4.Top = 250;

            this.Controls.Add(btn4);
            btn4.Click += Btn4_Click;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Button tıklanan = (Button)sender;
            string deger = " ";
            textBox1.Text = textBox1.Text + deger;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Button tıklanan = (Button)sender;
            string deger = tıklanan.Text;
            textBox1.Text = textBox1.Text + deger;
        }
    }
}
