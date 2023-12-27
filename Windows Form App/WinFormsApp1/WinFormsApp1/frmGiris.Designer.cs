namespace WinFormsApp1
{
    partial class frmGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            btnMinimize = new Button();
            ımageList1 = new ImageList(components);
            groupBox1 = new GroupBox();
            btnTemizle = new Button();
            btnKaydet = new Button();
            label2 = new Label();
            label1 = new Label();
            txtSoyadi = new TextBox();
            txtAdi = new TextBox();
            groupBox2 = new GroupBox();
            listIsimler = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.ImageAlign = ContentAlignment.MiddleLeft;
            btnMinimize.ImageKey = "simge.jpeg";
            btnMinimize.ImageList = ımageList1;
            btnMinimize.Location = new Point(862, 34);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Padding = new Padding(15, 0, 10, 0);
            btnMinimize.Size = new Size(378, 83);
            btnMinimize.TabIndex = 4;
            btnMinimize.Text = "Formu Simge Durumuna Getir";
            btnMinimize.TextAlign = ContentAlignment.MiddleRight;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "maks.png");
            ımageList1.Images.SetKeyName(1, "simge.jpeg");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSoyadi);
            groupBox1.Controls.Add(txtAdi);
            groupBox1.Controls.Add(btnMinimize);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1264, 253);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Butonlar";
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(148, 141);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(185, 48);
            btnTemizle.TabIndex = 3;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(339, 141);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(185, 48);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(58, 86);
            label2.Name = "label2";
            label2.Size = new Size(164, 35);
            label2.TabIndex = 2;
            label2.Text = "Soyadı :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(58, 44);
            label1.Name = "label1";
            label1.Size = new Size(164, 35);
            label1.TabIndex = 2;
            label1.Text = "Adı :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(228, 85);
            txtSoyadi.MaxLength = 50;
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(297, 35);
            txtSoyadi.TabIndex = 1;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(228, 44);
            txtAdi.MaxLength = 50;
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(297, 35);
            txtAdi.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listIsimler);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 253);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1264, 776);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // listIsimler
            // 
            listIsimler.FormattingEnabled = true;
            listIsimler.ItemHeight = 30;
            listIsimler.Location = new Point(45, 74);
            listIsimler.Name = "listIsimler";
            listIsimler.Size = new Size(486, 664);
            listIsimler.TabIndex = 0;
            // 
            // frmGiris
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1264, 1029);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Açılış Ekranı";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnMinimize;
        private ImageList ımageList1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtAdi;
        private TextBox txtSoyadi;
        private Label label2;
        private Label label1;
        private Button btnKaydet;
        private Button btnTemizle;
        private ListBox listIsimler;
    }
}
