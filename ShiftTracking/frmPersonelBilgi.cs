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
    public partial class frmPersonelBilgi : Form
    {
        public frmPersonelBilgi()
        {
            InitializeComponent();
        }

        private void frmPersonelBilgi_Load(object sender, EventArgs e)
        {
            cmbpersonelbilgi.DataSource = null;
            cmbpersonelbilgi.DataSource = PersonelData.AsciList;
            cmbpersonelbilgi.ToString();
           
        }
    }
}
