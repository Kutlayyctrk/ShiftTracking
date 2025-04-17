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
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        private void btnAscıOlusturma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAsciAdiEkleme.Text) ||
          string.IsNullOrWhiteSpace(txtAsciSoyadiEkleme.Text) ||
          string.IsNullOrWhiteSpace(cmbPersonelIstasyonEkleme.Text) ||
          string.IsNullOrWhiteSpace(cmbPozisyonEkle.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Personel ekleme işlemi
            Asci yeniAsci = new Asci(txtAsciAdiEkleme.Text, txtAsciSoyadiEkleme.Text, cmbPersonelIstasyonEkleme.Text, cmbPozisyonEkle.Text);
            PersonelData.AsciList.Add(yeniAsci);
            PersonelData.PersonelleriKaydet();

            MessageBox.Show("Personel başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Formu temizle
            txtAsciAdiEkleme.Clear();
            txtAsciSoyadiEkleme.Clear();
            cmbPersonelIstasyonEkleme.SelectedIndex = -1;

        }

        private void btnAsciOlusturma_Click(object sender, EventArgs e)
        {
            // Açık olan "Personel Sil" formunu bul
            frmPersonelSil silmeFormu = Application.OpenForms.OfType<frmPersonelSil>().FirstOrDefault();

            if (silmeFormu != null)
            {
                // Silme formundaki ComboBox güncellemesi
                silmeFormu.cmbesilinecekpersonel.DataSource = null;
                silmeFormu.cmbesilinecekpersonel.DataSource = PersonelData.AsciList;
                silmeFormu.cmbesilinecekpersonel.DisplayMember = "Name";
            }
            else
            {
                MessageBox.Show("Personel silme formu açık değil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

