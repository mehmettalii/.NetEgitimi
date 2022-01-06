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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] dizi1 = new string[5];

            dizi1[0] = "Ankara";
            dizi1[1] = "İstanbul";

            string[] dizi2 = { "Ankara", "İstanbul" };

            int boyut1 = dizi1.Length;

            int boyut2 = dizi2.Length;

            dizi1[0] = "İzmir";

            Array.Resize(ref dizi1, 10);

            Array.IndexOf(dizi1, "İstanbul");

            Array.LastIndexOf(dizi1, "İstanbul");

            Array.Sort(dizi1);

            Array.Reverse(dizi2);

            string[] dizi3 = new string[15];
            Array.Copy(dizi1, dizi3, dizi1.Length);

            Array.LastIndexOf(dizi1, "İstanbul");

            Array.Clear(dizi3, 0, 3);

            for (int i = 0; i < dizi1.Length; i++)
            {
                string Item = dizi1[i];
            }

            foreach (var item in dizi1)
            {

            }

            int index = 0;
            while (index < 10)
            {
                index++;
            }

            do
            {
                index++;
            } while (index < 10);
        }
    }
}
