using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace RepairWebApplication
{
    public partial class Remont : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RemontGridView.DataSource = ConnectToBase.Brigada.GetRepair();
            RemontGridView.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("New_rem.aspx?");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=remont_vagonov;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Remont WHERE TypeRepair like '" + TextBox1.Text+"%'", Conn);
            DataTable tb = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(tb);
            SearchGridView.DataSource = tb;
            SearchGridView.DataBind();
           
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(RemontGridView.SelectedRow.Cells[1].Text);
                ConnectToBase.Depo.DeleteRepair(id);
                RemontGridView.DataSource = ConnectToBase.Brigada.GetRepair();
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Локомотив был удален" + "');", true);
                RemontGridView.DataSource = ConnectToBase.Brigada.GetRepair();
                RemontGridView.DataBind();
            }
            catch (Exception)
            {

            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?");
        }

    }
}