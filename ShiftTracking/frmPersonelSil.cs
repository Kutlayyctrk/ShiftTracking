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
    public partial class frmPersonelSil : Form
    {
        public ComboBox cmbesilinecekpersonel;
        public frmPersonelSil()
        {
            InitializeComponent();
            cmbesilinecekpersonel = cmbsilinecekpersonel;


        }


        private void frmPersonelSil_Load(object sender, EventArgs e)
        {
            cmbsilinecekpersonel.DataSource = null;
            cmbsilinecekpersonel.DataSource = PersonelData.AsciList;
            cmbsilinecekpersonel.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (cmbsilinecekpersonel.SelectedIndex >= 0)
            {
                Asci secilenAsci = (Asci)cmbsilinecekpersonel.SelectedItem;
                secilenAsci.Durum = false; // Durumu pasif yap



                PersonelData.PersonelleriKaydet(); // Silme işlemini dosyaya da yansıt

                MessageBox.Show($"{secilenAsci.Name} başarıyla silindi!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz personeli seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
