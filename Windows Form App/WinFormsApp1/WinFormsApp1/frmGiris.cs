namespace WinFormsApp1
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Form açıldıktan sonra bu veri görünecek.";
            //this.WindowState = FormWindowState.Minimized;
            groupBox2.Text = "sonradan değiştirildi";
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Button btn = new Button();
            //btn.Text = "deneme";
            //btn.Name = "btnDeneme";
            //btn.Width = 200;
            //btn.Height = 100;
            //groupBox2.Controls.Add(btn);


            //MessageBox.Show($"Merhaba {txtAdi.Text} {txtSoyadi.Text}");
            listIsimler.Items.Add(txtAdi.Text + " " + txtSoyadi.Text);
            btnTemizle_Click(sender, e);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //txtAdi.Text = "";
            //txtSoyadi.Text = "";

            foreach (var item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
        }
    }
}
