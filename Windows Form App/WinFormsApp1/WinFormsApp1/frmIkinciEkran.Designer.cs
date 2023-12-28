namespace WinFormsApp1
{
    partial class frmIkinciEkran
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
            TreeNode treeNode19 = new TreeNode("Buzdolabı");
            TreeNode treeNode20 = new TreeNode("Çamaşır Makinesi");
            TreeNode treeNode21 = new TreeNode("Beyaz Eşya", new TreeNode[] { treeNode19, treeNode20 });
            TreeNode treeNode22 = new TreeNode("Masaüstü");
            TreeNode treeNode23 = new TreeNode("Notebook");
            TreeNode treeNode24 = new TreeNode("Bilgisayar", new TreeNode[] { treeNode22, treeNode23 });
            TreeNode treeNode25 = new TreeNode("Node14");
            TreeNode treeNode26 = new TreeNode("Node16");
            TreeNode treeNode27 = new TreeNode("Node17");
            TreeNode treeNode28 = new TreeNode("Node15", new TreeNode[] { treeNode26, treeNode27 });
            TreeNode treeNode29 = new TreeNode("Node11", new TreeNode[] { treeNode25, treeNode28 });
            TreeNode treeNode30 = new TreeNode("Node12");
            TreeNode treeNode31 = new TreeNode("Node13");
            TreeNode treeNode32 = new TreeNode("Telefon", new TreeNode[] { treeNode29, treeNode30, treeNode31 });
            TreeNode treeNode33 = new TreeNode("Elektronik", new TreeNode[] { treeNode21, treeNode24, treeNode32 });
            TreeNode treeNode34 = new TreeNode("Moda");
            TreeNode treeNode35 = new TreeNode("Node2");
            TreeNode treeNode36 = new TreeNode("Node3");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIkinciEkran));
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "Elma", "34,50", "8" }, 2);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "Çilek", "56,00", "8" }, 1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "Süt", "25,00", "18" }, 0);
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            treeView1 = new TreeView();
            ımageList1 = new ImageList(components);
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            ımageList2 = new ImageList(components);
            ımageList3 = new ImageList(components);
            cmbGorunum = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(332, 35);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(12, 73);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(332, 35);
            dateTimePicker2.TabIndex = 0;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Location = new Point(12, 125);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(332, 35);
            dateTimePicker3.TabIndex = 0;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.CustomFormat = "yyyy.MM.dd";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.Location = new Point(12, 178);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(332, 35);
            dateTimePicker4.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(354, 24);
            label1.Name = "label1";
            label1.Size = new Size(141, 30);
            label1.TabIndex = 1;
            label1.Text = "Format : Long";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 73);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 1;
            label2.Text = "Format : Short";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 125);
            label3.Name = "label3";
            label3.Size = new Size(140, 30);
            label3.TabIndex = 1;
            label3.Text = "Format : Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 183);
            label4.Name = "label4";
            label4.Size = new Size(166, 30);
            label4.TabIndex = 1;
            label4.Text = "Format : Custom";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Debug", "Release" });
            comboBox1.Location = new Point(12, 345);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(332, 38);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Debug", "Release" });
            comboBox2.Location = new Point(12, 399);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(332, 38);
            comboBox2.TabIndex = 2;
            // 
            // treeView1
            // 
            treeView1.ImageIndex = 0;
            treeView1.ImageList = ımageList1;
            treeView1.Location = new Point(14, 443);
            treeView1.Name = "treeView1";
            treeNode19.Name = "Node7";
            treeNode19.Text = "Buzdolabı";
            treeNode20.Name = "Node8";
            treeNode20.Text = "Çamaşır Makinesi";
            treeNode21.Name = "Node4";
            treeNode21.Text = "Beyaz Eşya";
            treeNode22.ImageIndex = 2;
            treeNode22.Name = "Node9";
            treeNode22.Text = "Masaüstü";
            treeNode23.Name = "Node10";
            treeNode23.Text = "Notebook";
            treeNode24.ImageIndex = 1;
            treeNode24.Name = "Node5";
            treeNode24.Text = "Bilgisayar";
            treeNode25.Name = "Node14";
            treeNode25.Text = "Node14";
            treeNode26.Name = "Node16";
            treeNode26.Text = "Node16";
            treeNode27.Name = "Node17";
            treeNode27.Text = "Node17";
            treeNode28.Name = "Node15";
            treeNode28.Text = "Node15";
            treeNode29.Name = "Node11";
            treeNode29.Text = "Node11";
            treeNode30.Name = "Node12";
            treeNode30.Text = "Node12";
            treeNode31.Name = "Node13";
            treeNode31.Text = "Node13";
            treeNode32.ImageIndex = 0;
            treeNode32.Name = "Node6";
            treeNode32.Text = "Telefon";
            treeNode33.ImageIndex = 2;
            treeNode33.Name = "Node0";
            treeNode33.SelectedImageKey = "4703487.png";
            treeNode33.Text = "Elektronik";
            treeNode34.Name = "Node1";
            treeNode34.Text = "Moda";
            treeNode35.Name = "Node2";
            treeNode35.Text = "Node2";
            treeNode36.Name = "Node3";
            treeNode36.Text = "Node3";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode33, treeNode34, treeNode35, treeNode36 });
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(484, 438);
            treeView1.TabIndex = 3;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "ico-phone.png");
            ımageList1.Images.SetKeyName(1, "4703487.png");
            ımageList1.Images.SetKeyName(2, "2317975_computer_desktop_electronic_monitor_pc_icon.png");
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem4, listViewItem5, listViewItem6 });
            listView1.LargeImageList = ımageList3;
            listView1.Location = new Point(584, 95);
            listView1.Name = "listView1";
            listView1.Size = new Size(809, 786);
            listView1.SmallImageList = ımageList2;
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ürün Adı";
            columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Fiyatı";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kdv Oran";
            columnHeader3.Width = 120;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth8Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "sut.jpeg");
            ımageList2.Images.SetKeyName(1, "cilek.png");
            ımageList2.Images.SetKeyName(2, "elma.jpeg");
            // 
            // ımageList3
            // 
            ımageList3.ColorDepth = ColorDepth.Depth8Bit;
            ımageList3.ImageStream = (ImageListStreamer)resources.GetObject("ımageList3.ImageStream");
            ımageList3.TransparentColor = Color.Transparent;
            ımageList3.Images.SetKeyName(0, "sut.jpeg");
            ımageList3.Images.SetKeyName(1, "cilek.png");
            ımageList3.Images.SetKeyName(2, "elma.jpeg");
            // 
            // cmbGorunum
            // 
            cmbGorunum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGorunum.FormattingEnabled = true;
            cmbGorunum.Items.AddRange(new object[] { "Büyük Resim Olarak Göster", "Küçük Resim Olarak Göster", "Detaylı Liste Olarak Göster", "Kolon Olarak Göster", "Liste Olarak Göster" });
            cmbGorunum.Location = new Point(1181, 51);
            cmbGorunum.Name = "cmbGorunum";
            cmbGorunum.Size = new Size(212, 38);
            cmbGorunum.TabIndex = 5;
            cmbGorunum.SelectedIndexChanged += cmbGorunum_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1064, 54);
            label5.Name = "label5";
            label5.Size = new Size(111, 30);
            label5.TabIndex = 6;
            label5.Text = "Görünüm :";
            // 
            // frmIkinciEkran
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 893);
            Controls.Add(label5);
            Controls.Add(cmbGorunum);
            Controls.Add(listView1);
            Controls.Add(treeView1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker4);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Name = "frmIkinciEkran";
            Text = "Form2";
            Load += frmIkinciEkran_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        public ComboBox comboBox2;
        private TreeView treeView1;
        private ImageList ımageList1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ImageList ımageList3;
        private ImageList ımageList2;
        private ComboBox cmbGorunum;
        private Label label5;
    }
}