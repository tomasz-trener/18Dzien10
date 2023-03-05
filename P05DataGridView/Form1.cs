using P04BibliotekaPolaczenieZBaza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=Zawodnicy;User ID=sa;Password=alx";
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            object[][] wynik=  pzb.WykonajZapytanie(txtSQL.Text);

            dgvDane.Rows.Clear();// czyścimy wiersze 
            // potem ustawiamy liczbe wyswietlanych kolumn 
            dgvDane.ColumnCount = wynik[0].Length;

            foreach (var wiersz in wynik)
            {
                dgvDane.Rows.Add(wiersz);
            }


        }
    }
}
