using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace MVCStudentproject.Models
{
    public class StudentDBHandler
    {
        SqlConnection con = null;
        public void Conncetion()
        {
            string constr = "server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=StudentItem";
            con = new SqlConnection(constr);
        }

        public bool InsertStudent(StudentModel st)
        {
            Conncetion();
            string qurey = "Insert into StudentItem values('" + st.Name + "','" + st.Rollno + "','" + st.Email + "','" + st.MobileNo + "')";
            SqlCommand cmd = new SqlCommand(qurey, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<StudentModel> GetStudent()
        {
            Conncetion();
            List<StudentModel> list = new List<StudentModel>();
            string query = "select * from studenttable";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            ad.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new StudentModel
                {
                    StdId = Convert.ToInt32(dr["StdId"]),
                    Name = Convert.ToString(dr["Name"]),
                    Rollno = Convert.ToInt32(dr["Rollno"]),
                    Email = Convert.ToString(dr["Email"]),
                    MobileNo = Convert.ToString(dr["MobileNo"])
                });
            }
            return list;

        }

        public bool UpdateStudent(StudentModel st)
        {
            Conncetion();
            string query = "update studenttable set Name='" + st.Name + "',Rollno='" + st.Rollno + "',Email='" + st.Email + "',MobileNo='" + st.MobileNo + "' where StdId='" + st.StdId + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteStudent(StudentModel st)
        {
            Conncetion();
            string query = "delete from studenttable where StdId='" + st.StdId + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
    