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
            button1 = new Button();
            btnIkinciForm = new Button();
            btnTemizle = new Button();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            btnKaydet = new Button();
            label2 = new Label();
            label1 = new Label();
            txtSoyadi = new TextBox();
            txtAdi = new TextBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnOku = new Button();
            btnDosyaKaydet = new Button();
            button2 = new Button();
            lblSaat = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            checkedListBox1 = new CheckedListBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            listIsimler = new ListBox();
            btnSil = new Button();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            timer1 = new System.Windows.Forms.Timer(components);
            fileSystemWatcher1 = new FileSystemWatcher();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
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
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnIkinciForm);
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSoyadi);
            groupBox1.Controls.Add(txtAdi);
            groupBox1.Controls.Add(btnMinimize);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1264, 249);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Butonlar";
            // 
            // button1
            // 
            button1.Location = new Point(847, 147);
            button1.Name = "button1";
            button1.Size = new Size(143, 70);
            button1.TabIndex = 6;
            button1.Text = "Form 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnIkinciForm
            // 
            btnIkinciForm.Location = new Point(996, 147);
            btnIkinciForm.Name = "btnIkinciForm";
            btnIkinciForm.Size = new Size(243, 70);
            btnIkinciForm.TabIndex = 6;
            btnIkinciForm.Text = "İkinci Formu Aç";
            btnIkinciForm.UseVisualStyleBackColor = true;
            btnIkinciForm.Click += btnIkinciForm_Click;
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
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(644, 100);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(158, 34);
            radioButton5.TabIndex = 5;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton1";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(644, 46);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(158, 34);
            radioButton4.TabIndex = 5;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton1";
            radioButton4.UseVisualStyleBackColor = true;
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
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(btnOku);
            groupBox2.Controls.Add(btnDosyaKaydet);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(lblSaat);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(checkedListBox1);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(listIsimler);
            groupBox2.Controls.Add(btnSil);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 249);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1264, 780);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(52, 493);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(463, 265);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnOku
            // 
            btnOku.Location = new Point(654, 585);
            btnOku.Name = "btnOku";
            btnOku.Size = new Size(125, 57);
            btnOku.TabIndex = 8;
            btnOku.Text = "Oku";
            btnOku.UseVisualStyleBackColor = true;
            btnOku.Click += btnOku_Click;
            // 
            // btnDosyaKaydet
            // 
            btnDosyaKaydet.Location = new Point(654, 510);
            btnDosyaKaydet.Name = "btnDosyaKaydet";
            btnDosyaKaydet.Size = new Size(125, 57);
            btnDosyaKaydet.TabIndex = 8;
            btnDosyaKaydet.Text = "Kaydet";
            btnDosyaKaydet.UseVisualStyleBackColor = true;
            btnDosyaKaydet.Click += btnDosyaKaydet_Click;
            // 
            // button2
            // 
            button2.Location = new Point(773, 34);
            button2.Name = "button2";
            button2.Size = new Size(148, 51);
            button2.TabIndex = 7;
            button2.Text = "Sayacı Başlat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaat.Location = new Point(952, 40);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(107, 42);
            lblSaat.TabIndex = 6;
            lblSaat.Text = "label3";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(701, 376);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(158, 34);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton1";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(701, 319);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(158, 34);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton1";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(701, 265);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(158, 34);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "asaa", "asdasd", "fgfggfhfg" });
            checkedListBox1.Location = new Point(902, 254);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(338, 484);
            checkedListBox1.TabIndex = 4;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(1074, 189);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(137, 34);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "checkBox1";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(1074, 149);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(137, 34);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // listIsimler
            // 
            listIsimler.FormattingEnabled = true;
            listIsimler.ItemHeight = 30;
            listIsimler.Location = new Point(45, 74);
            listIsimler.Name = "listIsimler";
            listIsimler.Size = new Size(486, 394);
            listIsimler.TabIndex = 0;
            toolTip1.SetToolTip(listIsimler, "Silmek yada değiştirmek için bir seçim yapabilirsiniz.\r\nasdad\r\nasad");
            listIsimler.SelectedIndexChanged += listIsimler_SelectedIndexChanged;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(537, 74);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(185, 48);
            btnSil.TabIndex = 2;
            btnSil.Text = "Seçili Kaydı Sil";
            toolTip1.SetToolTip(btnSil, "Silinen kayıtlar geri alınamaz");
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // toolTip1
            // 
            toolTip1.BackColor = SystemColors.Highlight;
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Başlık";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.Path = "C:\\temp";
            fileSystemWatcher1.SynchronizingObject = this;
            fileSystemWatcher1.Created += fileSystemWatcher1_Created;
            fileSystemWatcher1.Deleted += fileSystemWatcher1_Deleted;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "PNG Resimler|*.png|Jpeg Resimler|*.jpeg|Tüm Dosyalar|*.*";
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
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
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
        private Button btnSil;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckedListBox checkedListBox1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private Button btnIkinciForm;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Label lblSaat;
        private Button button2;
        private FileSystemWatcher fileSystemWatcher1;
        private Button btnOku;
        private Button btnDosyaKaydet;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PictureBox pictureBox1;
    }
}
