using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepairWebApplication
{
    public partial class New_rem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ConnectToBase.Depo.AddRepair(
                    TB1.Text.ToString(),
                    Convert.ToDouble(TB2.Text),
                    Convert.ToBoolean(TB3.Text),
                    Convert.ToInt32(TB4.Text),
                    DateTime.Parse(TB5.Text),
                    DateTime.Parse(TB6.Text),
                    TB7.Text.ToString(),
                    Convert.ToInt32(TB8.Text),
                    Convert.ToInt32(TB9.Text)
                    );
             Response.Redirect("Remont.aspx");
        }
    }
}