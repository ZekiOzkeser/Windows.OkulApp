using OkulApp.BLL;
using OkulApp.Models;
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
    public partial class frmOgrenciListesi : Form
    {
        DataTable dt = null;
        public frmOgrenciListesi()
        {
            InitializeComponent();
            grdOgrenciler.AutoGenerateColumns = false;
        }
        void OgrenciListele()
        {
            dt = StudentBL.OgrenciListele();
            grdOgrenciler.DataSource = dt;

        }

        private void frmOgrenciListesi_Load(object sender, EventArgs e)
        {

            OgrenciListele();
            ((DataGridViewComboBoxColumn)grdOgrenciler.Columns["clmClassroomId"]).DisplayMember = "ClassroomName";
            ((DataGridViewComboBoxColumn)grdOgrenciler.Columns["clmClassroomId"]).ValueMember = "ClassroomId";
            ((DataGridViewComboBoxColumn)grdOgrenciler.Columns["clmClassroomId"]).DataSource=ClassroomBL.SinifListesi();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            foreach (DataRow item in dt.Rows)
            {
             
               switch (item.RowState)
                {
                    case DataRowState.Added:
                        s.Name = item["Name"].ToString();
                        s.Surname = item["Surname"].ToString();
                        s.NationId = item["NationId"].ToString();
                        s.SchoolNumber = item["Schoolnumber"].ToString();
                        StudentBL.InsertStudent(s);
                        break;
                    case DataRowState.Deleted:
                        s.StudentId = Convert.ToInt32(item["StudentId",DataRowVersion.Original]);
                        StudentBL.DeleteStudent(s.StudentId);
                        break;
                    case DataRowState.Modified:
                        s.Name = item["Name"].ToString();
                        s.Surname = item["Surname"].ToString();
                        s.NationId = item["NationId"].ToString();
                        s.SchoolNumber = item["Schoolnumber"].ToString();
                        s.StudentId = Convert.ToInt32(item["StudentId"]);
                        StudentBL.UpdateStudent(s);
                        break;
                    default:
                        break;
                }
            }
        }

        private void grdOgrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOgrenciKayit frm = new frmOgrenciKayit();
            frm.studentid = (int)dt.Rows[e.RowIndex]["StudentId"];
            frm.txtName.Text = dt.Rows[e.RowIndex]["Name"].ToString();
            frm.txtSurname.Text = dt.Rows[e.RowIndex]["Surname"].ToString();
            frm.txtSchoolNumber.Text = dt.Rows[e.RowIndex]["SchoolNumber"].ToString();
            frm.txtNationId.Text = dt.Rows[e.RowIndex]["NationId"].ToString();
            frm.cmbSiniflar.SelectedValue = dt.Rows[e.RowIndex]["ClassroomId"];
            frm.ShowDialog();

        }
    }
}
