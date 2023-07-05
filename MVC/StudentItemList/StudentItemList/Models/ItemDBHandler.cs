using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentItemList.Models
{
    public class ItemDBHandler
    {
       
            private SqlConnection con;
            private void connection()
            {
                // string constring = ConfigurationManager.ConnectionStrings["CompShopConString"].ToString();
                string constr = "server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=StudConString";
                con = new SqlConnection(constr);
            }
        public List<ItemModels> GetItemList()
        {
            connection();

            List<ItemModels> iList = new List<ItemModels>();

            string query = "SELECT * FROM StudentList";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                iList.Add(new ItemModels
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Name = Convert.ToString(dr["Name"]),
                    Address = Convert.ToString(dr["Address"]),
                    Mobno = Convert.ToInt32(dr["Mobno"])
                });
            }
            return iList;
        }
        public bool InsertItem(ItemModels iList)
        {
            connection();
            string query = "INSERT INTO itemlist VALUES('" + iList.ID + "','" + iList.Name + "'," + iList.Address + "',"+iList.Mobno +")";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }




        public bool UpdateItem(ItemModels iList)
        {
            connection();
            string query = "UPDATE ItemList SET Name = '" + iList.ID + "', Name = '" + iList.Address + "',Mobno = " + iList.Address + " WHERE ID = " + iList.ID;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }


        public bool DeleteItem(int id)
        {
            connection();
            string query = "DELETE FROM ItemList WHERE ID = " + id;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }
    }
}
    