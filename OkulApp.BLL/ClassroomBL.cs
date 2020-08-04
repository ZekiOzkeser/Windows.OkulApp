using OkulApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.DAL;

namespace OkulApp.BLL
{
    public class ClassroomBL
    {
        public static bool InsertClassroom(Classroom cs)
        {
            try
            {
                SqlParameter[] p =
                 {
                new SqlParameter("@ClassroomId",cs.ClassroomId),
                new SqlParameter("@ClassroomName",cs.ClassroomName),
                new SqlParameter("@Capacity",cs.Capacity)
            };

                return Helper.ExecuteNonQuery("Insert into tblClassrooms values(@ClassroomName,@Capacity)", p) > 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static bool UpdateClassroom(Classroom cs)
        {
            try
            {
                SqlParameter[] p =
                 {
                new SqlParameter("@ClassroomId",cs.ClassroomId),
                new SqlParameter("@ClassroomName",cs.ClassroomName),
                new SqlParameter("@Capacity",cs.Capacity)
            };

                return Helper.ExecuteNonQuery("Update tblClassrooms Set ClassroomName=@ClassroomName,Capacity=@Capacity Where ClassroomId=@ClassroomId", p) > 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static bool DeleteClassroom(int classroomid)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@ClassroomId", classroomid) };

                return Helper.ExecuteNonQuery("Delete from tblClassrooms  Where ClassroomId=@ClassroomId", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DataTable SinifListesi()
        {
            return Helper.MyDataTable("Select ClassroomName,ClassroomId from tblClassrooms", null);

        }

    }
}
