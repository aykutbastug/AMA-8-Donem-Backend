using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class frmIkinciEkran : Form
    {
        public frmIkinciEkran()
        {
            InitializeComponent();
        }

        private void frmIkinciEkran_Load(object sender, EventArgs e)
        {
            //treeView1.Nodes
        }

        private void cmbGorunum_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Büyük Resim Olarak Göster
            //Küçük Resim Olarak Göster
            //Detaylı Liste Olarak Göster
            //Kolon Olarak Göster
            //Liste Olarak Göster

            if (cmbGorunum.SelectedIndex == 0)
                listView1.View = View.LargeIcon;
            else if (cmbGorunum.SelectedIndex == 1)
                listView1.View = View.SmallIcon;
            else if (cmbGorunum.SelectedIndex == 2)
                listView1.View = View.Tile;
            else if (cmbGorunum.SelectedIndex == 3)
                listView1.View = View.Details;
            else if (cmbGorunum.SelectedIndex == 4)
                listView1.View = View.List;
        }
    }
}
