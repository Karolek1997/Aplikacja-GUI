using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SklepZButami
{
    public partial class AplikacjaSklepu : Form
    {
        public AplikacjaSklepu()
        {
            InitializeComponent();
        }

        private void produkt_button_CLick (object sender, EventArgs e)
        {
            Dodaj_Produkt dodaj_Produkt = new Dodaj_Produkt();
            dodawaj_Produk.ShowDialog();
        }

        private void AplikacjaSklepu_Load(object sender, EventArgs e)
        {

        }
    }
}
