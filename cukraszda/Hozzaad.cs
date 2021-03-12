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
    public partial class Hozzaad : Form
    {
        public Hozzaad()
        {
            InitializeComponent();
        }

        private bool Atment = true;

        private void Urites()
        {
            tbAr.Text = "";
            tbEgyseg.Text = "";
            tbNev.Text = "";
            tbTipus.Text = "";
            Atment = false;
        }

        private void btnFelvetel_Click(object sender, EventArgs e)
        {
            if (tbAr.TextLength == 0 || tbEgyseg.TextLength == 0 || tbNev.TextLength == 0 || tbTipus.TextLength ==0)
            {
                MessageBox.Show("Egy vagy több kitöltendő mező üresen maradt!");
                Urites();
            }

            if (!int.TryParse(tbAr.Text, out int szam))
            {
                MessageBox.Show("Nem megfelelő formátumot adtál meg árnak!");
                Urites();
            }

            for (int i = 0; i < 9; i++)
            {
                if (tbNev.Text.Contains($"{i}") || tbEgyseg.Text.Contains($"{i}") || tbTipus.Text.Contains($"{i}"))
                {
                    MessageBox.Show("Rossz helyre írtál számokat! (név, egység, típus?)");
                    Urites();
                }
            }

            if (Atment)
            {
                StreamWriter ki = new StreamWriter("cuki.txt", true);
                ki.WriteLine($"{tbNev.Text};{tbTipus.Text};{cbDijazott.Checked};{tbAr.Text};{tbEgyseg.Text}");
                ki.Close();
                MessageBox.Show("A hozzáadás sikeres volt!");
                sikereshozzaadas = true;
                this.Close();
            }
        }

        private bool sikereshozzaadas = false;

        public bool sikeresHozzaadas
        {
            get { return sikereshozzaadas; }
        }

    }
}
