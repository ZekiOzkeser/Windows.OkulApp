namespace Vektorel.Windows.OkulApp
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrenciİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciKayıtİşlemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciListelemeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınıfİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınıfKayıtİşlemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınıfListelemeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciİşlemleriToolStripMenuItem,
            this.öğretmenİşlemleriToolStripMenuItem,
            this.sınıfİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciİşlemleriToolStripMenuItem
            // 
            this.öğrenciİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciKayıtİşlemiToolStripMenuItem,
            this.öğrenciListelemeİşlemleriToolStripMenuItem});
            this.öğrenciİşlemleriToolStripMenuItem.Name = "öğrenciİşlemleriToolStripMenuItem";
            this.öğrenciİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.öğrenciİşlemleriToolStripMenuItem.Text = "Öğrenci İşlemleri";
            // 
            // öğrenciKayıtİşlemiToolStripMenuItem
            // 
            this.öğrenciKayıtİşlemiToolStripMenuItem.Name = "öğrenciKayıtİşlemiToolStripMenuItem";
            this.öğrenciKayıtİşlemiToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.öğrenciKayıtİşlemiToolStripMenuItem.Text = "Öğrenci Kayıt İşlemi";
            this.öğrenciKayıtİşlemiToolStripMenuItem.Click += new System.EventHandler(this.öğrenciKayıtİşlemiToolStripMenuItem_Click);
            // 
            // öğrenciListelemeİşlemleriToolStripMenuItem
            // 
            this.öğrenciListelemeİşlemleriToolStripMenuItem.Name = "öğrenciListelemeİşlemleriToolStripMenuItem";
            this.öğrenciListelemeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.öğrenciListelemeİşlemleriToolStripMenuItem.Text = "Öğrenci Listeleme İşlemleri";
            this.öğrenciListelemeİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.öğrenciListelemeİşlemleriToolStripMenuItem_Click);
            // 
            // öğretmenİşlemleriToolStripMenuItem
            // 
            this.öğretmenİşlemleriToolStripMenuItem.Name = "öğretmenİşlemleriToolStripMenuItem";
            this.öğretmenİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.öğretmenİşlemleriToolStripMenuItem.Text = "Öğretmen İşlemleri";
            // 
            // sınıfİşlemleriToolStripMenuItem
            // 
            this.sınıfİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sınıfKayıtİşlemiToolStripMenuItem,
            this.sınıfListelemeİşlemleriToolStripMenuItem});
            this.sınıfİşlemleriToolStripMenuItem.Name = "sınıfİşlemleriToolStripMenuItem";
            this.sınıfİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.sınıfİşlemleriToolStripMenuItem.Text = "Sınıf İşlemleri";
            // 
            // sınıfKayıtİşlemiToolStripMenuItem
            // 
            this.sınıfKayıtİşlemiToolStripMenuItem.Name = "sınıfKayıtİşlemiToolStripMenuItem";
            this.sınıfKayıtİşlemiToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.sınıfKayıtİşlemiToolStripMenuItem.Text = "Sınıf Kayıt İşlemi";
            this.sınıfKayıtİşlemiToolStripMenuItem.Click += new System.EventHandler(this.sınıfKayıtİşlemiToolStripMenuItem_Click);
            // 
            // sınıfListelemeİşlemleriToolStripMenuItem
            // 
            this.sınıfListelemeİşlemleriToolStripMenuItem.Name = "sınıfListelemeİşlemleriToolStripMenuItem";
            this.sınıfListelemeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.sınıfListelemeİşlemleriToolStripMenuItem.Text = "Sınıf Listeleme İşlemleri";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 476);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okul Yönetim Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciKayıtİşlemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListelemeİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretmenİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınıfİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınıfKayıtİşlemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınıfListelemeİşlemleriToolStripMenuItem;
    }
}

