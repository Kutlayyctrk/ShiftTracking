namespace ShiftTracking
{
    public partial class frmGirisEkrani : Form
    {

        private void frmGirisEkrani_Load(object sender, EventArgs e)
        {
            PersonelData.PersonelleriYukle(); // Program ba�larken JSON dosyas�ndan y�kle
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
                MessageBox.Show("Ho�geldin Chef");
                this.Hide();
                frmSecenekler frmSecenekler = new frmSecenekler();
                frmSecenekler.Show();

            }
            else
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre hatal�");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }

        }

    }
}
