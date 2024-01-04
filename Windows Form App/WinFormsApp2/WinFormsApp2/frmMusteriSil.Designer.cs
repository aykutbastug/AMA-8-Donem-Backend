namespace WinFormsApp2
{
    partial class frmMusteriSil
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
            btnVazgec = new Button();
            btnSil = new Button();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblCustomerId = new Label();
            lblCompanyName = new Label();
            lblCity = new Label();
            lblContactName = new Label();
            lblCountry = new Label();
            SuspendLayout();
            // 
            // btnVazgec
            // 
            btnVazgec.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVazgec.Location = new Point(470, 381);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.Size = new Size(174, 75);
            btnVazgec.TabIndex = 18;
            btnVazgec.Text = "Vazgeç";
            btnVazgec.UseVisualStyleBackColor = true;
            btnVazgec.Click += btnVazgec_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(650, 381);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(174, 75);
            btnSil.TabIndex = 17;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(31, 295);
            label5.Name = "label5";
            label5.Size = new Size(274, 45);
            label5.TabIndex = 7;
            label5.Text = "Country :";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(31, 195);
            label3.Name = "label3";
            label3.Size = new Size(274, 45);
            label3.TabIndex = 8;
            label3.Text = "Contact Name :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(31, 244);
            label4.Name = "label4";
            label4.Size = new Size(274, 45);
            label4.TabIndex = 9;
            label4.Text = "City :";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(31, 144);
            label2.Name = "label2";
            label2.Size = new Size(274, 45);
            label2.TabIndex = 10;
            label2.Text = "Company Name :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(31, 93);
            label1.Name = "label1";
            label1.Size = new Size(274, 45);
            label1.TabIndex = 12;
            label1.Text = "Cutomer ID :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCustomerId
            // 
            lblCustomerId.BorderStyle = BorderStyle.Fixed3D;
            lblCustomerId.Location = new Point(311, 93);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(513, 45);
            lblCustomerId.TabIndex = 12;
            lblCustomerId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCompanyName
            // 
            lblCompanyName.BorderStyle = BorderStyle.Fixed3D;
            lblCompanyName.Location = new Point(311, 144);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(513, 45);
            lblCompanyName.TabIndex = 10;
            lblCompanyName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCity
            // 
            lblCity.BorderStyle = BorderStyle.Fixed3D;
            lblCity.Location = new Point(311, 244);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(513, 45);
            lblCity.TabIndex = 9;
            lblCity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblContactName
            // 
            lblContactName.BorderStyle = BorderStyle.Fixed3D;
            lblContactName.Location = new Point(311, 195);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(513, 45);
            lblContactName.TabIndex = 8;
            lblContactName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCountry
            // 
            lblCountry.BorderStyle = BorderStyle.Fixed3D;
            lblCountry.Location = new Point(311, 295);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(513, 45);
            lblCountry.TabIndex = 7;
            lblCountry.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmMusteriSil
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 484);
            Controls.Add(btnVazgec);
            Controls.Add(btnSil);
            Controls.Add(lblCountry);
            Controls.Add(label5);
            Controls.Add(lblContactName);
            Controls.Add(label3);
            Controls.Add(lblCity);
            Controls.Add(label4);
            Controls.Add(lblCompanyName);
            Controls.Add(label2);
            Controls.Add(lblCustomerId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMusteriSil";
            Text = "Müşteri Sil";
            Load += frmMusteriSil_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVazgec;
        private Button btnSil;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label lblCustomerId;
        private Label lblCompanyName;
        private Label lblCity;
        private Label lblContactName;
        private Label lblCountry;
    }
}