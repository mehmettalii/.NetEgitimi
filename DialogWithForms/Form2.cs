using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogWithForms
{
    public partial class Form2 : Form
    {
        public Form1 BaseForm;

        public Cevap Answer;
        public string Metin;
        public string Title;

        public Form2(string title, string metin, Cevap answer)
        {
            InitializeComponent();

            InitializeComponent();

            Title = title;
            Metin = metin;
            Answer = answer;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Button btn1 = new Button();
            Button btn2 = new Button();

            btn1.Click += btn1_Click;
            btn2.Click += btn2_Click;

            if (Answer == Cevap.yesNo)
            {
                btn1.Text = "Yes";
                btn2.Text = "No";
                btn1.Location = new Point(300, 216);
                btn2.Location = new Point(400, 216);

                this.Text = Title;
                this.label1.Text = Metin;

                this.Controls.Add(btn1);
                this.Controls.Add(btn2);
            }
            else if (Answer == Cevap.okCancel)
            {
                btn1.Text = "Ok";
                btn2.Text = "Cancel";
                btn1.Location = new Point(300, 216);
                btn2.Location = new Point(400, 216);

                this.Text = Title;
                this.label1.Text = Metin;

                this.Controls.Add(btn1);
                this.Controls.Add(btn2);
            }
            else
            {
                btn1.Text = "Ok";
                btn1.Location = new Point(306, 216);

                this.Text = Title;
                this.label1.Text = Metin;

                this.Controls.Add(btn1);
            }
        }
    }
}
