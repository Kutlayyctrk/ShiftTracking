namespace ShiftTracking
{
    public partial class frmGirisEkrani : Form
    {
        public frmGirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtUserName.Text;
            string sifre = txtPassword.Text;

            if(kullaniciadi=="avenuechef"&& sifre=="ekip5594")
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
