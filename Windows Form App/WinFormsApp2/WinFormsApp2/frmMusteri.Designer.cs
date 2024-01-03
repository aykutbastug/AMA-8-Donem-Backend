namespace WinFormsApp2
{
    partial class frmMusteri
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
            label1 = new Label();
            txtCustomerId = new TextBox();
            label2 = new Label();
            txtCompanyName = new TextBox();
            label3 = new Label();
            txtContactName = new TextBox();
            label4 = new Label();
            txtCity = new TextBox();
            label5 = new Label();
            txtCountry = new TextBox();
            btnKaydet = new Button();
            btnVazgec = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(32, 65);
            label1.Name = "label1";
            label1.Size = new Size(274, 45);
            label1.TabIndex = 0;
            label1.Text = "Cutomer ID :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerId.Location = new Point(312, 63);
            txtCustomerId.MaxLength = 5;
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(513, 45);
            txtCustomerId.TabIndex = 0;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(32, 116);
            label2.Name = "label2";
            label2.Size = new Size(274, 45);
            label2.TabIndex = 0;
            label2.Text = "Company Name :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCompanyName.Location = new Point(312, 114);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(513, 45);
            txtCompanyName.TabIndex = 1;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(32, 167);
            label3.Name = "label3";
            label3.Size = new Size(274, 45);
            label3.TabIndex = 0;
            label3.Text = "Contact Name :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtContactName
            // 
            txtContactName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContactName.Location = new Point(312, 165);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(513, 45);
            txtContactName.TabIndex = 2;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(32, 216);
            label4.Name = "label4";
            label4.Size = new Size(274, 45);
            label4.TabIndex = 0;
            label4.Text = "City :";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.Location = new Point(312, 214);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(513, 45);
            txtCity.TabIndex = 3;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(32, 267);
            label5.Name = "label5";
            label5.Size = new Size(274, 45);
            label5.TabIndex = 0;
            label5.Text = "Country :";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCountry.Location = new Point(312, 265);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(513, 45);
            txtCountry.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Location = new Point(651, 353);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(174, 75);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnVazgec
            // 
            btnVazgec.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVazgec.Location = new Point(471, 353);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.Size = new Size(174, 75);
            btnVazgec.TabIndex = 6;
            btnVazgec.Text = "Vazgeç";
            btnVazgec.UseVisualStyleBackColor = true;
            btnVazgec.Click += btnVazgec_Click;
            // 
            // frmMusteri
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 468);
            Controls.Add(btnVazgec);
            Controls.Add(btnKaydet);
            Controls.Add(txtCountry);
            Controls.Add(label5);
            Controls.Add(txtContactName);
            Controls.Add(txtCity);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtCompanyName);
            Controls.Add(label2);
            Controls.Add(txtCustomerId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMusteri";
            Text = "Müşteri Bilgileri";
            Load += frmMusteri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnKaydet;
        private Button btnVazgec;
        public TextBox txtCustomerId;
        public TextBox txtCompanyName;
        public TextBox txtContactName;
        public TextBox txtCity;
        public TextBox txtCountry;
    }
}