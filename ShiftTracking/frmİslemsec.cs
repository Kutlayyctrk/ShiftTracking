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
    public partial class frmSecenekler : Form
    {
        public frmSecenekler()
        {
            InitializeComponent();
        }
        private void cmbpersonelislem_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormAc1(cmbislemler.SelectedItem.ToString());
        }
        private void FormAc1(string secilen)
        {
            Form yeniForm = null;

            switch (secilen)
            {
                case "Yeni Personel Ekle":
                    yeniForm = new frmPersonelEkle();
                    break;
                case "Personel Sil":
                    yeniForm = new frmPersonelSil();
                    break;
                case "Personel Listesi Görüntüle":
                    yeniForm = new PersonelListesi();
                    break;

                case "Yeni Hafta Shifti Oluştur":
                    yeniForm = new frmYeniShift();
                    break;
                case "Mevcut Shifti Güncelle":
                    yeniForm = new frmMevcutShiftDuzenle();
                    break;
                case "Geçmiş Shift Görüntüle":
                    yeniForm = new frmGecmisShift();
                    break;
                default:
                    MessageBox.Show("Geçerli bir seçenek seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            if (yeniForm != null)
            {
                yeniForm.Show();
            }



        }
        private void frmSecenekler_Load(object sender, EventArgs e)
        {
            cmbislemler.Items.Add("Yeni Personel Ekle");
            cmbislemler.Items.Add("Personel Sil");
            cmbislemler.Items.Add("Personel Listesi Görüntüle");
            cmbislemler.Items.Add("Yeni Hafta Shifti Oluştur");
            cmbislemler.Items.Add("Mevcut Shifti Güncelle");
            cmbislemler.Items.Add("Geçmiş Shift Görüntüle");
        }


    }
}
