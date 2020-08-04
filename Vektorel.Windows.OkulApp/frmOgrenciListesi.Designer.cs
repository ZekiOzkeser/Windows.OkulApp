namespace Vektorel.Windows.OkulApp
{
    partial class frmOgrenciListesi
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
            this.grdOgrenciler = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSchoolNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClassroomId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdOgrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOgrenciler
            // 
            this.grdOgrenciler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOgrenciler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmSurname,
            this.clmSchoolNumber,
            this.clmNationId,
            this.clmClassroomId});
            this.grdOgrenciler.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdOgrenciler.Location = new System.Drawing.Point(0, 0);
            this.grdOgrenciler.Name = "grdOgrenciler";
            this.grdOgrenciler.Size = new System.Drawing.Size(596, 310);
            this.grdOgrenciler.TabIndex = 0;
            this.grdOgrenciler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOgrenciler_CellClick);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(190, 351);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(160, 23);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Değişikleri Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // clmName
            // 
            this.clmName.DataPropertyName = "Name";
            this.clmName.HeaderText = "Ad";
            this.clmName.Name = "clmName";
            // 
            // clmSurname
            // 
            this.clmSurname.DataPropertyName = "Surname";
            this.clmSurname.HeaderText = "Soyad";
            this.clmSurname.Name = "clmSurname";
            // 
            // clmSchoolNumber
            // 
            this.clmSchoolNumber.DataPropertyName = "SchoolNumber";
            this.clmSchoolNumber.HeaderText = "Numarası";
            this.clmSchoolNumber.Name = "clmSchoolNumber";
            // 
            // clmNationId
            // 
            this.clmNationId.DataPropertyName = "NationId";
            this.clmNationId.HeaderText = "TC Kimlik No";
            this.clmNationId.Name = "clmNationId";
            // 
            // clmClassroomId
            // 
            this.clmClassroomId.DataPropertyName = "ClassroomId";
            this.clmClassroomId.HeaderText = "Sınıfı";
            this.clmClassroomId.Name = "clmClassroomId";
            this.clmClassroomId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmClassroomId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmOgrenciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 411);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grdOgrenciler);
            this.Name = "frmOgrenciListesi";
            this.Text = "frmOgrenciListesi";
            this.Load += new System.EventHandler(this.frmOgrenciListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOgrenciler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdOgrenciler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSchoolNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNationId;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmClassroomId;
    }
}