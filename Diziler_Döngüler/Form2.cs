using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_Döngüler
{
    public partial class Form2 : Form
    {
        int counter = 0;

        int counter2 = 0;

        public Form2()
        {
            InitializeComponent();
        }

        string[] arrayList = new string[81];

        string[] arrayList2 = new string[81];

        private void button1_Click(object sender, EventArgs e)
        {
            string il = textBox1.Text;

            if (Array.IndexOf(arrayList, il) == -1)
            {
                arrayList[counter] = textBox1.Text;

                listBox1.Items.Add(arrayList[counter]);
                counter++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Sort(arrayList);

            listBox1.Items.Clear();

            for (int counter = 0; counter < arrayList.Length; counter++)
            {
                if (arrayList[counter] != null)
                {
                    listBox1.Items.Add(arrayList[counter]);

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Array.Sort(arrayList);
            Array.Reverse(arrayList);

            listBox1.Items.Clear();

            for (int counter = 0; counter < arrayList.Length; counter++)
            {
                if (arrayList[counter] != null)
                {
                    listBox1.Items.Add(arrayList[counter]);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }
            var ind = Array.IndexOf(arrayList, listBox1.SelectedItem);

            var value = arrayList[ind];
            arrayList[ind] = arrayList[ind - 1];
            arrayList[ind - 1] = value;


            listBox1.Items.Clear();

            for (int counter = 0; counter < arrayList.Length; counter++)
            {
                if (arrayList[counter] != null)
                {
                    listBox1.Items.Add(arrayList[counter]);
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == arrayList.Where(x => x != null).Count() - 1 || listBox1.SelectedIndex == -1)
            {
                return;
            }
            var ind = Array.IndexOf(arrayList, listBox1.SelectedItem);

            var value = arrayList[ind];
            arrayList[ind] = arrayList[ind + 1];
            arrayList[ind + 1] = value;


            listBox1.Items.Clear();

            for (int counter = 0; counter < arrayList.Length; counter++)
            {
                if (arrayList[counter] != null)
                {
                    listBox1.Items.Add(arrayList[counter]);
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var degerInd = Array.IndexOf(arrayList, listBox1.SelectedItem);
            var deger = arrayList[degerInd];

            arrayList2[counter2] = deger;
            counter2++;
            listBox2.Items.Clear();

            for (int i = 0; i < arrayList2.Length; i++)
            {
                if (arrayList2[i] != null)
                {
                    listBox2.Items.Add(arrayList2[i]);
                }

            }
            listBox1.Items.Clear();
            for (int i = 0; i < arrayList.Length; i++)
            {
                arrayList[degerInd] = null;
                if (arrayList[i] != null)
                {
                    listBox1.Items.Add(arrayList[i]);
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            var degerInd = Array.IndexOf(arrayList2, listBox2.SelectedItem);
            var deger = arrayList2[degerInd];

            arrayList[counter] = deger;
            counter++;
            listBox1.Items.Clear();

            for (int i = 0; i < arrayList.Length; i++)
            {
                if (arrayList[i] != null)
                {
                    listBox1.Items.Add(arrayList[i]);
                }

            }
            listBox2.Items.Clear();
            for (int i = 0; i < arrayList2.Length; i++)
            {
                arrayList2[degerInd] = null;
                if (arrayList2[i] != null)
                {
                    listBox2.Items.Add(arrayList2[i]);
                }

            }
        }
    }
}
