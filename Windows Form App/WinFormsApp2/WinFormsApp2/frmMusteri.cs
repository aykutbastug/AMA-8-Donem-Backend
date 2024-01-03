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
        public frmMusteri(bool isNewRecord)
        {
            InitializeComponent();
            this.isNewRecord = isNewRecord;
        }
        
        private void frmMusteri_Load(object sender, EventArgs e)
        {
            if (!isNewRecord)
                txtCustomerId.Enabled = false;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (isNewRecord)
            {
                SqlCommand cmdControl = new SqlCommand("select count(*) from dbo.Customers where CustomerID=@CustomerID", MyConnection.Connection);
                cmdControl.Parameters.AddWithValue("CustomerID", txtCustomerId.Text);
                MyConnection.Connection.Open();

                int rowCount = (int)cmdControl.ExecuteScalar();

                if (rowCount == 0)
                {
                    SqlCommand cmd = new SqlCommand("insert into dbo.Customers (CustomerID, CompanyName, ContactName, City, Country) values (@CustomerID, @CompanyName, @ContactName, @City, @Country)", MyConnection.Connection);
                    cmd.Parameters.AddWithValue("CustomerID", txtCustomerId.Text);
                    cmd.Parameters.AddWithValue("CompanyName", txtCompanyName.Text);
                    cmd.Parameters.AddWithValue("ContactName", txtContactName.Text);
                    cmd.Parameters.AddWithValue("City", txtCity.Text);
                    cmd.Parameters.AddWithValue("Country", txtCountry.Text);

                    cmd.ExecuteNonQuery();
                    MyConnection.Connection.Close();
                    this.Close();
                }
                else
                {
                    MyConnection.Connection.Close();
                    MessageBox.Show("Girilen CustomerId değeri zaten kayıtlı.\nLütfen farklı bir ID girin.");
                }

            }
            else
            {
                //update cümlesi çalıştırılacak
            }
        }
    }
}
