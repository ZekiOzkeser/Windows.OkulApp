using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//n Katmanlı Mimari - Layered Architecture
namespace Vektorel.DAL
{
    public class Helper
    {
        static SqlConnection cn = null;
        public static int ExecuteNonQuery(string cmdtext, SqlParameter[] p)
        {
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
                SqlCommand cmd = new SqlCommand(cmdtext, cn);
                if (p != null)
                {
                    cmd.Parameters.AddRange(p);
                }
                if (cn != null && cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                int sonuc = cmd.ExecuteNonQuery();

                return sonuc;
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                if (cn != null && cn.State != System.Data.ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }
        public static SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p)
        {
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
                SqlCommand cmd = new SqlCommand(cmdtext, cn);
                if (p != null)
                {
                    cmd.Parameters.AddRange(p);
                }
                if (cn != null && cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }

                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //1-SqlDataAdapter
        //2-DataTable

        public static DataTable MyDataTable(string cmdtext, SqlParameter[] p)
        {
            using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmdtext, cn);
                if (p != null)
                {
                    da.SelectCommand.Parameters.AddRange(p);
                }
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

        }
    }
}



