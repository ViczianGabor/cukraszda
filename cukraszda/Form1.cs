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
    }
}
