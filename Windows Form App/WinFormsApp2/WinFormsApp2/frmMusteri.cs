using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class frmMusteri : Form
    {
        private bool isNewRecord = false;

        private Musteri musteri;

        public frmMusteri(bool isNewRecord, Musteri musteri)
        {
            InitializeComponent();
            this.isNewRecord = isNewRecord;
            this.musteri = musteri;
        }

        private void frmMusteri_Load(object sender, EventArgs e)
        {
            if (!isNewRecord)
            {
                txtCustomerId.Enabled = false;

                txtCustomerId.Text = musteri.CustomerId;
                txtCompanyName.Text = musteri.CompanyName;
                txtContactName.Text = musteri.ContactName;
                txtCity.Text = musteri.City;
                txtCountry.Text = musteri.Country;
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            musteri.CustomerId = txtCustomerId.Text;
            musteri.CompanyName = txtCompanyName.Text;
            musteri.ContactName = txtContactName.Text;
            musteri.Country = txtCountry.Text;
            musteri.City = txtCity.Text;

            if (isNewRecord)
            {
                SqlCommand cmdControl = new SqlCommand("select count(*) from dbo.Customers where CustomerID=@CustomerID", MyConnection.Connection);
                cmdControl.Parameters.AddWithValue("CustomerID", txtCustomerId.Text);
                MyConnection.Connection.Open();
                int rowCount = (int)cmdControl.ExecuteScalar();
                MyConnection.Connection.Close();

                if (rowCount == 0)
                {
                    MusteriMetotlari.KayitEkle(musteri);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Girilen CustomerId değeri zaten kayıtlı.\nLütfen farklı bir ID girin.");
                }

            }
            else
            {
                MusteriMetotlari.Guncelle(musteri);
                this.Close();
            }
        }

        private void frmMusteri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnKaydet_Click(btnKaydet, null);
            else if (e.KeyCode == Keys.Escape)
                btnVazgec_Click(btnVazgec, null);
        }
    }
}
