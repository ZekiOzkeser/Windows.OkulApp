using OkulApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.DAL;

namespace OkulApp.BLL
{
    public class StudentBL
    {
        public static bool InsertStudent(Student s)
        {
            //SqlConnection cn = null;
            try
            {
                #region uzun yol
                //SQL Injection -açıklığın adı
                //cn = new SqlConnection();
                //cn.ConnectionString = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = cn;
                //SqlParameter p = new SqlParameter("@Name", txtName.Text);
                //SqlParameter p1 = new SqlParameter("@Surname", txtSurname.Text);
                //cmd.Parameters.Add(p);
                //cmd.Parameters.Add(p1); 
                #endregion

                SqlParameter[] p =
                {
                    new SqlParameter("@Name",s.Name),
                    new SqlParameter("@Surname",s.Surname),
                    new SqlParameter("@SchoolNumber",s.SchoolNumber),
                    new SqlParameter("@NationId",s.NationId),
                    new SqlParameter("@ClassroomId",s.ClassroomId)
                };
                #region uzun yol
                //cmd.Parameters.AddRange(p);
                //cmd.CommandText = "Insert into tblStudents values(@Name,@Surname,@SchoolNumber,@NationId)";

                //if (cn != null && cn.State != ConnectionState.Open)
                //{
                //    cn.Open();
                //}

                //int sonuc = cmd.ExecuteNonQuery();  //kullanmadan önce mutlaka connection açmamız gerekli...


                #endregion

                return Helper.ExecuteNonQuery("Insert into tblStudents values(@Name,@Surname,@SchoolNumber,@NationId,@ClassroomId)", p) > 0;
                #region MyRegion
                //if (sonuc > 0)
                //{
                //    return true;
                //}

                //else
                //{
                //    return false;
                //} 
                #endregion               
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            #region MyRegion
            //finally
            //{
            //    if (cn != null && cn.State != ConnectionState.Closed)
            //    {
            //        cn.Close();
            //    }
            //} 
            #endregion
        }

        public static bool UpdateStudent(Student s)
        {
            try
            {

                SqlParameter[] p =
                {
                    new SqlParameter("@Name",s.Name),
                    new SqlParameter("@Surname",s.Surname),
                    new SqlParameter("@SchoolNumber",s.SchoolNumber),
                    new SqlParameter("@NationId",s.NationId),
                    new SqlParameter("@StudentId",s.StudentId),

                };

                return Helper.ExecuteNonQuery("Update tblStudents Set Name=@Name,Surname=@Surname,SchoolNumber=@SchoolNumber,NationId=@NationId Where StudentId=@StudentId", p) > 0;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool DeleteStudent(int studentid)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@StudentId", studentid) };
                return Helper.ExecuteNonQuery("Delete from tblStudents Where StudentId=@StudentId", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Student GetStudentBySchoolNumber(string schoolnumber)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@SchoolNumber", schoolnumber) };
                SqlDataReader dr = Helper.ExecuteReader("Select * from tblStudents where SchoolNumber=@SchoolNumber", p);
                Student s = null;
                if (dr.Read())
                {
                    s = new Student();
                    s.Name = dr["Name"].ToString();
                    s.Surname = dr["Surname"].ToString();
                    s.NationId = dr["NationId"].ToString();
                    s.SchoolNumber = schoolnumber;
                    s.StudentId = Convert.ToInt32(dr["StudentId"]);
                    s.ClassroomId = Convert.ToInt32(dr["ClassroomId"]);
                    dr.Close();
                }
                return s;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DataTable OgrenciListele()
        {
            return Helper.MyDataTable("Select s.Name,s.NationId,s.SchoolNumber,s.StudentId,s.Surname,c.ClassroomName,c.ClassroomId from tblStudents s Inner Join tblClassrooms c On s.ClassroomId=c.ClassroomId", null);
        }
    }
}
