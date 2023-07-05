namespace Connectioninsert.Models;
 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

    public class Itemdbhandler

    
    {
                SqlConnection con = null;
        public void connection()
        {
            string constr = "server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=compshopdbwithoutef";

            con = new SqlConnection(constr);

        }

        // insert itemmethod to insert record into itemlist table
        public bool InsertItem(ItemModel ilist)
        {
            connection();
            string query = "insert into itemlist values('" + ilist.Name + "','" + ilist.Category + "','" + ilist.Price + "')";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            int i = command.ExecuteNonQuery();
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
