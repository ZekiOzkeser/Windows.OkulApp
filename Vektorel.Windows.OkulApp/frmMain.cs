using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.Windows.OkulApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void öğrenciKayıtİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciKayit frm = new OkulApp.frmOgrenciKayit();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiChildren.Length>0)
            {
                MessageBox.Show("Devam eden işlem olduğundan kapatamazsınız!!");
                e.Cancel = true;
            }
        }

        private void sınıfKayıtİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClassroom frm = new OkulApp.frmClassroom();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;
            frm.Show();
        }

        private void öğrenciListelemeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciListesi frm = new frmOgrenciListesi();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
