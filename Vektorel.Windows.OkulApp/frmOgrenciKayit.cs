using OkulApp.BLL;
using OkulApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLib;

namespace Vektorel.Windows.OkulApp
{
    public partial class frmOgrenciKayit : Form
    {
        public int studentid = 0;

        public frmOgrenciKayit()
        {
            InitializeComponent();
            SinifYukle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                bool sonuc;

                Student st = new Student();
                st.Name = txtName.Text.Trim();
                st.Surname = txtSurname.Text.Trim();
                st.NationId = txtNationId.Text.Trim();
                st.SchoolNumber = txtSchoolNumber.Text.Trim();
                st.StudentId = studentid;
                st.ClassroomId =(int)cmbSiniflar.SelectedValue;

                sonuc = studentid == 0 ? StudentBL.InsertStudent(st) : StudentBL.UpdateStudent(st);
                MessageBox.Show(sonuc ? "Başarılı" : "Başarısız");
                btnCancel.PerformClick();

            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        if (ex.Message.Contains("NationId"))
                        {
                            MessageBox.Show("Bu Tc Kimlik numarası zaten kayıtlı!!" + ex.Number);
                        }
                        else
                        {
                            MessageBox.Show("Bu Öğrenci numarası zaten kayıtlı!!" + ex.Number);
                        }
                        break;

                    default:
                        MessageBox.Show("Veritabanı hatası!!");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen Hata!!");
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            frmFindStudent frm = new OkulApp.frmFindStudent();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            studentid = 0;
            btnKaydet.Text = "Ekle";
            Utility.CleanTextBoxes(grpOgrenciBilgileri.Controls);
            //txtName.Text = string.Empty;
            //txtNationId.Text = string.Empty;
            //txtSchoolNumber.Text = string.Empty;
            //txtSurname.Text = string.Empty;
            btnCancel.Visible = false;

        }

        void SinifYukle()
        {
            cmbSiniflar.DisplayMember = "ClassroomName";
            cmbSiniflar.ValueMember = "ClassroomId";
            cmbSiniflar.DataSource = ClassroomBL.SinifListesi();
        }

        private void frmOgrenciKayit_Load(object sender, EventArgs e)
        {
           
        }
    }

}
