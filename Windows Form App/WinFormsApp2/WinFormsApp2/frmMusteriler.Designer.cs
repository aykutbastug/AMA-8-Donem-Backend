namespace WinFormsApp2
{
    partial class frmMusteriler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriler));
            toolStrip1 = new ToolStrip();
            btnYeniKayit = new ToolStripButton();
            panel1 = new Panel();
            btnAra = new Button();
            label1 = new Label();
            txtAra = new TextBox();
            gridListe = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuItemSil = new ToolStripMenuItem();
            menuItemDuzenle = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridListe).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(28, 28);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnYeniKayit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1385, 58);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnYeniKayit
            // 
            btnYeniKayit.Image = (Image)resources.GetObject("btnYeniKayit.Image");
            btnYeniKayit.ImageScaling = ToolStripItemImageScaling.None;
            btnYeniKayit.ImageTransparentColor = Color.Magenta;
            btnYeniKayit.Name = "btnYeniKayit";
            btnYeniKayit.Size = new Size(154, 52);
            btnYeniKayit.Text = "Yeni Kayıt";
            btnYeniKayit.Click += btnYeniKayit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAra);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtAra);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(1385, 84);
            panel1.TabIndex = 1;
            // 
            // btnAra
            // 
            btnAra.Image = (Image)resources.GetObject("btnAra.Image");
            btnAra.Location = new Point(980, 17);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(65, 46);
            btnAra.TabIndex = 2;
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 26);
            label1.Name = "label1";
            label1.Size = new Size(132, 30);
            label1.TabIndex = 1;
            label1.Text = "Müşteri Ara :";
            // 
            // txtAra
            // 
            txtAra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAra.Location = new Point(164, 18);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(810, 45);
            txtAra.TabIndex = 0;
            txtAra.KeyPress += txtAra_KeyPress;
            // 
            // gridListe
            // 
            gridListe.AllowUserToAddRows = false;
            gridListe.AllowUserToDeleteRows = false;
            gridListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridListe.ContextMenuStrip = contextMenuStrip1;
            gridListe.Dock = DockStyle.Fill;
            gridListe.Location = new Point(0, 142);
            gridListe.Name = "gridListe";
            gridListe.ReadOnly = true;
            gridListe.RowHeadersWidth = 72;
            gridListe.RowTemplate.Height = 37;
            gridListe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridListe.Size = new Size(1385, 878);
            gridListe.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(28, 28);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { menuItemSil, menuItemDuzenle });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(163, 76);
            // 
            // menuItemSil
            // 
            menuItemSil.Name = "menuItemSil";
            menuItemSil.Size = new Size(162, 36);
            menuItemSil.Text = "Sil";
            menuItemSil.Click += menuItemSil_Click;
            // 
            // menuItemDuzenle
            // 
            menuItemDuzenle.Name = "menuItemDuzenle";
            menuItemDuzenle.Size = new Size(162, 36);
            menuItemDuzenle.Text = "Düzenle";
            menuItemDuzenle.Click += menuItemDuzenle_Click;
            // 
            // frmMusteriler
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 1020);
            Controls.Add(gridListe);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "frmMusteriler";
            Text = "Müşteri Listesi";
            WindowState = FormWindowState.Maximized;
            Load += frmMusteriler_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridListe).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnYeniKayit;
        private Panel panel1;
        private Label label1;
        private TextBox txtAra;
        private Button btnAra;
        private DataGridView gridListe;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuItemSil;
        private ToolStripMenuItem menuItemDuzenle;
    }
}