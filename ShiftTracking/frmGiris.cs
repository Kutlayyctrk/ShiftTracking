namespace ShiftTracking
{
    public partial class frmGirisEkrani : Form
    {

        private void frmGirisEkrani_Load(object sender, EventArgs e)
        {
            PersonelData.PersonelleriYukle(); // Program baþlarken JSON dosyasýndan yükle
        }
      

        public frmGirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtUserName.Text;
            string sifre = txtPassword.Text;

            if (kullaniciadi == "a" && sifre == "aa")
            {
                MessageBox.Show("Hoþgeldin Chef");
                this.Hide();
                frmSecenekler frmSecenekler = new frmSecenekler();
                frmSecenekler.Show();

            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre hatalý");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }

        }

    }
}
