using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cukraszda
{
    public partial class FrmFo : Form
    {
        static List<sutemeny> adatok = new List<sutemeny>();

        public FrmFo()
        {
            InitializeComponent();
        }

        private void btnOlvas_Click(object sender, EventArgs e)
        {
            StreamReader be = new StreamReader("cuki.txt");
            while (!be.EndOfStream)
            {
                string[] a = be.ReadLine().Split(';');
                adatok.Add(new sutemeny(a[0],a[1],Convert.ToBoolean(a[2]),int.Parse(a[3]),a[4]));
            }

            be.Close();
        }

        private void btnmasodik_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random szam = new Random();
            listBox1.Items.Add("2." + adatok[szam.Next(0, adatok.Count)].Nev);
        }

        private void btnhatodik_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Dictionary<string, int> sutik = new Dictionary<string, int>();
            foreach (var a in adatok)
            {
                if (!sutik.ContainsKey(a.Tipus))
                {
                    sutik.Add(a.Tipus, 1);
                }
                else
                {
                    sutik[a.Tipus]++;
                }
            }
            StreamWriter ki = new StreamWriter("stat.csv");
            foreach (var s in sutik)
            {
                ki.WriteLine($"{s.Key};{s.Value}");
            }
            ki.Close();
            listBox1.Items.Add("6. Kiírás sikeres");
        }

        private void btnotodik_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> sutik = new List<string>();

            foreach (var t in adatok)
            {
                if (!sutik.Contains(t.Nev))
                {
                    listBox1.Items.Add(t.Nev + " " + t.Tipus);
                    sutik.Add(t.Nev);
                }
            }
            listBox1.Items.Add("Sikeres fájlba írás!");
        }

        private void btnNegyedik_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int db = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].Dijazott == true)
                {
                    //listBox1.Items.Add(adatok[i].Nev);
                    db++;
                }
            }
            listBox1.Items.Add($"{db} darab féle díjnyertes sütemény közül lehet választaniS.");
        }

        private void btnharmadik_Click(object sender, EventArgs e)
        {


            listBox1.Items.Clear();



            int legolcsobbar = 999999999;
            string legolcsobbnev = "";



            int legdragabbar = 0;
            string legdragabbnev = "";



            foreach (var i in adatok)
            {
                if (legdragabbar < i.Ar)
                {
                    legdragabbar = i.Ar;
                    legdragabbnev = i.Nev;
                }
            }



            foreach (var i in adatok)
            {
                if (legolcsobbar > i.Ar)
                {
                    legolcsobbar = i.Ar;
                    legolcsobbnev = i.Nev;
                }
            }




            listBox1.Items.Add($"Legdrágább sütemény: {legdragabbnev} - {legdragabbar} forint");
            listBox1.Items.Add($"Legdrágább sütemény: {legolcsobbnev} - {legolcsobbar} forint");
        }

        private void btnhetedik_Click(object sender, EventArgs e)
        {
            if (tbhetes.Text == "")
            {
                MessageBox.Show("Nem irtál be süteménynevet!");
            }
            else
            {
                StreamWriter ki = new StreamWriter("arajanlat.txt");
                int db = 0;
                int ar = 0;
                
                foreach (var t in adatok)
                {
                    if (t.Tipus.Contains(tbhetes.Text))
                    {
                        ki.WriteLine(t.Nev+";"+t.Ar+";"+t.EgysegNev);
                        ar += t.Ar;
                        db++;
                    }
                }
                ki.Close();
                if (db == 0)
                {
                    MessageBox.Show("Nincs megfelelő sütink. kérjük válassz mást!");
                }
                else
                {
                    double atlag = ar / db;
                    MessageBox.Show($"{db} süti lett a fájlba írva és az átlaguk: {atlag} Ft");
                    
                }
            }
        }
    }
}
