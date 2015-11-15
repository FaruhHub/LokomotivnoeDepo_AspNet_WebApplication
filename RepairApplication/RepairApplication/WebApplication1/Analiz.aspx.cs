using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepairWebApplication
{
    public partial class Analiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = ConnectToBase.Brigada.GetMoneyByRepair();
            dataGridView2.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?");
        }
    }
}