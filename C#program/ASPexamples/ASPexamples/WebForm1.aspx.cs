using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPexamples
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            switch (DropDownList1.Text)
            {
                case "india":
                    DropDownList2.Items.Add("nagpur");
                    DropDownList2.Items.Add("Amravati");
                    DropDownList2.Items.Add("Mumbai");
                    DropDownList2.Items.Add("Delhi");
                    break;
                case "USA":
                    DropDownList2.Items.Add("Texas");
                    DropDownList2.Items.Add("California");
                    DropDownList2.Items.Add("tenessee");
                    break;
                case "Nepal":
                    DropDownList2.Items.Add("Rukkum");
                    break;

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("country" + DropDownList1.Text + "<br>");
            sb.Append("city" + DropDownList2.Text + "<br>");
            foreach(ListItem list in CheckBoxList1.Items)
            {
                if(list.Selected)
                {
                    sb.Append("course" + list.Value + "<br>");
                }
            }
            Label1.Text = sb.ToString();
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}