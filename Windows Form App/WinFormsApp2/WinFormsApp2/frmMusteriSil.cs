using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class frmMusteriSil : Form
    {
        private Musteri musteri;
        public frmMusteriSil(Musteri musteri)
        {
            InitializeComponent();
            this.musteri = musteri;
        }

        private void frmMusteriSil_Load(object sender, EventArgs e)
        {
            lblCustomerId.Text = musteri.CustomerId;
            lblCompanyName.Text = musteri.CompanyName;
            lblContactName.Text = musteri.ContactName;
            lblCountry.Text = musteri.Country;
            lblCity.Text = musteri.City;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            MusteriMetotlari.Sil(musteri.CustomerId);
            this.Close();
        }
    }
}
