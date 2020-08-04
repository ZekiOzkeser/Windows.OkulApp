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
    public partial class frmFindStudent : Form
    {
        public frmFindStudent()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Student s = StudentBL.GetStudentBySchoolNumber(txtSchoolNumber.Text.Trim());
            if (s == null)
            {
                MessageBox.Show("Öğrenci Bulunamadı");
            }
            else
            {
                frmOgrenciKayit frm = (frmOgrenciKayit)Application.OpenForms["frmOgrenciKayit"];
                frm.txtName.Text = s.Name;
                frm.txtNationId.Text = s.NationId;
                frm.txtSchoolNumber.Text = s.SchoolNumber;
                frm.txtSurname.Text = s.Surname;
                frm.studentid = s.StudentId;
                frm.btnKaydet.Text = "Güncelle";
                frm.btnCancel.Visible = true;
                frm.cmbSiniflar.SelectedValue = s.ClassroomId;
                this.Close();
            }
        }
    }
}
