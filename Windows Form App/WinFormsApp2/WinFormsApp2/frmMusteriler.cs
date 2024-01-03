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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }

        //string connectionString = "server=AYKUTBASTUG-ZEN;database=Northwind;Trusted_Connection=true;";
        //string connectionString1 = "server=AYKUTBASTUG-ZEN;database=Northwind;uid=aykut;pwd=12345;";
        //string connectionString2 = "server=AYKUTBASTUG-ZEN;database=Northwind;user id=aykut;password=12345;";

        //SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwindContext"].ToString());
        private void frmMusteriler_Load(object sender, EventArgs e)
        {

            //SqlCommand sqlCommand = new SqlCommand("",connection);
            //SqlCommand sqlCommand = new SqlCommand();
            //sqlCommand.Connection = connection;
            //sqlCommand.CommandType = CommandType.StoredProcedure; //eğerki stored procedure tetikleyeceksek
            //sqlCommand.CommandText = "select CustomerID, CompanyName, ContactName, City, Country from dbo.Customers order by CompanyName";
            //connection.Open();

            //SqlDataReader reader = sqlCommand.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Columns.Add("CustomerID");
            //dt.Columns.Add("CompanyName");
            //dt.Columns.Add("ContactName");
            //dt.Columns.Add("City");
            //dt.Columns.Add("Country");

            //while (reader.Read())
            //{
            //    dt.Rows.Add(reader["CustomerID"], reader["CompanyName"], reader["ContactName"], reader["City"], reader["Country"]);
            //}
            //reader.Close();
            //connection.Close();


            SqlDataAdapter da = new SqlDataAdapter("select top 20 CustomerID, CompanyName, ContactName, City, Country from dbo.Customers order by CompanyName", MyConnection.Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridListe.DataSource = dt;


            //DataSet dataSet = new DataSet(); //eğerki sorgu sonucunda birden fazla tablo dönecek ise DataSet sınıfı kullanılır.
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            //string sql = "select CustomerID, CompanyName, ContactName, City, Country from dbo.Customers where CompanyName like '%" + txtAra.Text + "%' order by CompanyName";
            //string sql = "select CustomerID, CompanyName, ContactName, City, Country from dbo.Customers where CompanyName = '" + txtAra.Text + "'";
            string sql = "select CustomerID, CompanyName, ContactName, City, Country from dbo.Customers where CompanyName like '%' + @param1 + '%' order by CompanyName";

            SqlDataAdapter da = new SqlDataAdapter(sql, MyConnection.Connection);
            //da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("param1", txtAra.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridListe.DataSource = dt;
        }

        private void txtAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAra_Click(btnAra, null);
            }
        }

        private void menuItemSil_Click(object sender, EventArgs e)
        {

        }

        private void menuItemDuzenle_Click(object sender, EventArgs e)
        {
            frmMusteri frmMusteri = new frmMusteri(false);
            frmMusteri.txtCustomerId.Text = "";
            
            frmMusteri.ShowDialog();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            frmMusteri frmMusteri = new frmMusteri(true);
            frmMusteri.ShowDialog();
        }
    }
}
