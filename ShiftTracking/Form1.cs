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
