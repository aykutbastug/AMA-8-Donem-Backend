namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriler frm = new frmMusteriler();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
