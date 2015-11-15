using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepairWebApplication
{
    public partial class Brigadi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["ByID"]);
                brigadadataGridView.DataSource = ConnectToBase.Brigada.GetBrigads(id);
                brigadadataGridView.DataBind();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?");
        }

    }
}