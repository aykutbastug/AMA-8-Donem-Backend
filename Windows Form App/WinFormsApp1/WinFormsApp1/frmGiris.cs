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

        private void listIsimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listIsimler.SelectedItems.Count == 0)
                return;

            string seciliSatir = listIsimler.SelectedItem as string;


            txtAdi.Text = seciliSatir.Split(' ')[0];
            txtSoyadi.Text = seciliSatir.Split(' ')[1];
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listIsimler.SelectedItems.Count == 0)
                return;


            if (MessageBox.Show("Kaydı silmek istediğinize emin misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;


            listIsimler.Items.RemoveAt(listIsimler.SelectedIndex);
            btnTemizle_Click(btnTemizle, e);
        }

        private void btnIkinciForm_Click(object sender, EventArgs e)
        {
            frmIkinciEkran frm = new frmIkinciEkran();
            frm.comboBox2.Items.Clear();
            frm.comboBox2.Items.Add("Bilgisayar");
            frm.comboBox2.Items.Add("Beyaz Eşya");
            frm.comboBox2.Items.Add("Televizyon");


            //frm.Show();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            listIsimler.Items.Add(e.Name + " dosyası oluşturuldu");
        }

        private void fileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {
            listIsimler.Items.Add(e.Name + " dosyası silindi");
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnDosyaKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}
