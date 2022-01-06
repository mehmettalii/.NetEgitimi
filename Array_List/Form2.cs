using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_List
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // ARRAYLİST KULLANIMI

        private void Form2_Load(object sender, EventArgs e)
        {
            ArrayList arrayList1 = new ArrayList { }; // içindeki verileri object türünde tutar.

            //arrayList1.add(50);

            //arrayList1.add("Bilge Adam");

            //arrayList1.Add(true);

            object ilkEleman = arrayList1[0];
            string ilkElaman2 = arrayList1[0].ToString();
            int ilkEleman3 = Convert.ToInt32(arrayList1[0]);
            //Button ilkEleman4 = { Button }arrayList1[0]; // unboxing

            arrayList1.Remove(50);
            arrayList1.RemoveAt(0);

            arrayList1.Insert(3, "Deger");

            arrayList1.Sort(); //Sıralama yapmak için
            arrayList1.Reverse(); //Ters Çevirmek için

            //arrayList1.TrimSize(); //Dizinin kapasitesini içindeki eleman sayısına eşitler

            int boyut1 = arrayList1.Capacity;

            arrayList1.Contains("Bilge Adam"); //Dizide o eleman var mı yok mu

            arrayList1.IndexOf("Bilge Adam");

            arrayList1.LastIndexOf("Bilge Adam");
        }
    }
}
