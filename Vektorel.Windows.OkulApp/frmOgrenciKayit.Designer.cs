namespace Vektorel.Windows.OkulApp
{
    partial class frmOgrenciKayit
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
            this.grpOgrenciBilgileri = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.lblNationId = new System.Windows.Forms.Label();
            this.txtNationId = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblSchoolNumber = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSchoolNumber = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbSiniflar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOgrenciBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgrenciBilgileri
            // 
            this.grpOgrenciBilgileri.Controls.Add(this.label1);
            this.grpOgrenciBilgileri.Controls.Add(this.cmbSiniflar);
            this.grpOgrenciBilgileri.Controls.Add(this.btnCancel);
            this.grpOgrenciBilgileri.Controls.Add(this.btnBul);
            this.grpOgrenciBilgileri.Controls.Add(this.lblNationId);
            this.grpOgrenciBilgileri.Controls.Add(this.txtNationId);
            this.grpOgrenciBilgileri.Controls.Add(this.btnKaydet);
            this.grpOgrenciBilgileri.Controls.Add(this.lblSchoolNumber);
            this.grpOgrenciBilgileri.Controls.Add(this.lblSurname);
            this.grpOgrenciBilgileri.Controls.Add(this.lblName);
            this.grpOgrenciBilgileri.Controls.Add(this.txtSchoolNumber);
            this.grpOgrenciBilgileri.Controls.Add(this.txtSurname);
            this.grpOgrenciBilgileri.Controls.Add(this.txtName);
            this.grpOgrenciBilgileri.Location = new System.Drawing.Point(41, 12);
            this.grpOgrenciBilgileri.Name = "grpOgrenciBilgileri";
            this.grpOgrenciBilgileri.Size = new System.Drawing.Size(235, 291);
            this.grpOgrenciBilgileri.TabIndex = 0;
            this.grpOgrenciBilgileri.TabStop = false;
            this.grpOgrenciBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(98, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Vazgeç";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(159, 222);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(44, 23);
            this.btnBul.TabIndex = 9;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // lblNationId
            // 
            this.lblNationId.AutoSize = true;
            this.lblNationId.Location = new System.Drawing.Point(8, 117);
            this.lblNationId.Name = "lblNationId";
            this.lblNationId.Size = new System.Drawing.Size(67, 13);
            this.lblNationId.TabIndex = 8;
            this.lblNationId.Text = "Tc Kimlik No";
            // 
            // txtNationId
            // 
            this.txtNationId.Location = new System.Drawing.Point(89, 114);
            this.txtNationId.MaxLength = 11;
            this.txtNationId.Name = "txtNationId";
            this.txtNationId.Size = new System.Drawing.Size(119, 20);
            this.txtNationId.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(68, 222);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblSchoolNumber
            // 
            this.lblSchoolNumber.AutoSize = true;
            this.lblSchoolNumber.Location = new System.Drawing.Point(31, 93);
            this.lblSchoolNumber.Name = "lblSchoolNumber";
            this.lblSchoolNumber.Size = new System.Drawing.Size(44, 13);
            this.lblSchoolNumber.TabIndex = 7;
            this.lblSchoolNumber.Text = "Numara";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(38, 67);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(37, 13);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Soyad";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(55, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(20, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Ad";
            // 
            // txtSchoolNumber
            // 
            this.txtSchoolNumber.Location = new System.Drawing.Point(89, 90);
            this.txtSchoolNumber.MaxLength = 12;
            this.txtSchoolNumber.Name = "txtSchoolNumber";
            this.txtSchoolNumber.Size = new System.Drawing.Size(119, 20);
            this.txtSchoolNumber.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(89, 64);
            this.txtSurname.MaxLength = 50;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(119, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 38);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 20);
            this.txtName.TabIndex = 0;
            // 
            // cmbSiniflar
            // 
            this.cmbSiniflar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSiniflar.FormattingEnabled = true;
            this.cmbSiniflar.Location = new System.Drawing.Point(89, 140);
            this.cmbSiniflar.Name = "cmbSiniflar";
            this.cmbSiniflar.Size = new System.Drawing.Size(119, 21);
            this.cmbSiniflar.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sınıf Seçiniz";
            // 
            // frmOgrenciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 337);
            this.Controls.Add(this.grpOgrenciBilgileri);
            this.Name = "frmOgrenciKayit";
            this.Load += new System.EventHandler(this.frmOgrenciKayit_Load);
            this.grpOgrenciBilgileri.ResumeLayout(false);
            this.grpOgrenciBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgrenciBilgileri;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblSchoolNumber;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNationId;
        private System.Windows.Forms.Button btnBul;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtSchoolNumber;
        public System.Windows.Forms.TextBox txtSurname;
        public System.Windows.Forms.TextBox txtNationId;
        public System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbSiniflar;
    }
}