using OkulApp.BLL;
using OkulApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.Windows.OkulApp
{
    public partial class frmClassroom : Form
    {
        public int classroomid = 0;
        public frmClassroom()
        {
            InitializeComponent();
        }

        private void frmClassroom_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                bool sonuc;

                Classroom cs = new Classroom();
                cs.ClassroomName = txtClassName.Text.Trim();
                cs.Capacity = Convert.ToInt32(txtCapacity.Text.Trim());

                sonuc = classroomid == 0 ? ClassroomBL.InsertClassroom(cs) : ClassroomBL.UpdateClassroom(cs);
                MessageBox.Show(sonuc ? "Başarılı" : "Başarısız");
                btnCancel.PerformClick();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata"+ ex.Number);
               
            }


        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            frmFindClassroom frm = new frmFindClassroom();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
