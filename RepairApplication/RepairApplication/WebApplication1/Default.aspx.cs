using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepairWebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RepairGridView.DataSource = ConnectToBase.Depo.GetDepo();
            RepairGridView.DataBind();
        }

        protected void PersonGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            RepairGridView.PageIndex = e.NewPageIndex;
            RepairGridView.DataBind();
        }

        protected void PersonGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CheckBox1.Checked)
                {
                    int id = int.Parse(RepairGridView.SelectedRow.Cells[1].Text);
                    dataGridView1.DataSource = ConnectToBase.Depo.GetLokomotiv(id);
                    dataGridView1.DataBind();
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(RepairGridView.SelectedRow.Cells[1].Text);
                dataGridView1.DataSource = ConnectToBase.Depo.GetLokomotiv(id);
                dataGridView1.DataBind();

            }
            catch (Exception ex)
            {

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(RepairGridView.SelectedRow.Cells[1].Text);
                Response.Redirect("Brigadi.aspx?ByID=" + id);
            }
            catch (Exception)
            {
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Remont.aspx?");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Analiz.aspx?");
        }
    }
}