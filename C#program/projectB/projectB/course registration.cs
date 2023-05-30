using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectB
{
    public static class course_registration
    {
        private static string connectionString = "server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=institute;";
        //method to create connection
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                //conn.Open();

                return conn;
            }
            catch (Exception ee)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }

        }
        public static DataSet GetNation()
        {
            string query = "select * from TableNation";
            SqlConnection conn = GetConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds, "TableNation");
            return ds;
        }


        public static DataSet GetStates(string NationName)
        {
            string query = "select s.stateId,s.stateName from TableStates s inner join Tablenation n on s.NationId=n.NationId where NationName=@NationName";
            SqlConnection conn = GetConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@nationname", NationName);
            da.Fill(ds, "TableStates");
            return ds;
        }


        public static DataSet GetCitys(string StateName)
        {
            string query = "select c.CityId,c.CityName from TableCitys c inner join TableStates s on c.StateId=s.StateId where StateName=@StateName";
            SqlConnection conn = GetConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@statename", StateName);
            da.Fill(ds, "TableCitys");
            return ds;
        }
        //method to save record in TableCourseRegDetail
        public static string saveTableCourseRegDetails(int CategoryId, string FullName, int GenderId)
        {
            SqlConnection con = GetConnection();
            con.Open();
            string query = "insert into TableCourseRegDetails values(@categoryid,@fullname,@genderid)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@categoryid", CategoryId);
            command.Parameters.AddWithValue("@fullname", FullName);
            command.Parameters.AddWithValue("@genderid", GenderId);
            command.ExecuteNonQuery();
            con.Close();
            return "record saved in TableCourseRegDetails";
        }
        //method to save record in tableregaddress
        static int CourseId = 0;
        public static string saveTableRegAddress1(int NationId, int StateId, int CityId)
        {
            SqlConnection con = GetConnection();
            con.Open();
            string query = "SELECT top 1 CourseRegId FROM TableCourseRegDetails ORDER BY CourseRegId DESC ";
            SqlCommand command = new SqlCommand(query, con);
            CourseId = Convert.ToInt32(command.ExecuteScalar());
            query = "insert into TableRegAddress1 values(@courseregid,@nationid,@stateid,@cityid)";
            command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@courseregid", CourseId);
            command.Parameters.AddWithValue("@nationid", NationId);
            command.Parameters.AddWithValue("@stateid", StateId);
            command.Parameters.AddWithValue("@cityid", CityId);

            command.ExecuteNonQuery();
            con.Close();
            return "record saved in TableCourseDetails";
        }
        //method to save record in tablefeedetail
        public static string saveTableFeeDetail(double TotalAmount, double MinPer, double PaidAmount, double BalAmount, DateTime PaidDate)
        {
            SqlConnection con = GetConnection();
            con.Open();
            string query = "insert into TableFeeDetail values(@courseregid,@totalamount,@minper,@paidamount,@balamount,@paiddate)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@courseregid", CourseId);
            command.Parameters.AddWithValue("@totalamount", TotalAmount);
            command.Parameters.AddWithValue("@minper", MinPer);
            command.Parameters.AddWithValue("@paidamount", PaidAmount);
            command.Parameters.AddWithValue("@balamount", BalAmount);
            command.Parameters.AddWithValue("@paiddate", PaidDate);

            command.ExecuteNonQuery();
            con.Close();
            return "record saved in TableFeeDetail";

        }

    }

}
