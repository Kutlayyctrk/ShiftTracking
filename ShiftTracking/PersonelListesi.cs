using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftTracking
{
    public partial class PersonelListesi : Form
    {
        public PersonelListesi()
        {
            InitializeComponent();
        }

        private void PersonelListesi_Load(object sender, EventArgs e)
        {
            dgwPersonelListe.DataSource = null;
            dgwPersonelListe.DataSource = PersonelData.AsciList;
            dgwPersonelListe.Columns["Durum"].ReadOnly = true;
        }

        private void dgwPersonelListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
