using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarihselIslemler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime date = dateTimePicker1.Value;
            //TimeSpan fark = DateTime.Now - date;
            //int yas = fark.Days / 365;
            //label1.Text = yas.ToString();

            //Yada

            int birthDay = dateTimePicker1.Value.Year;
            int now = DateTime.Now.Year;
            string age = Convert.ToString(now - birthDay);
            label1.Text = age;
        }
    }
}
