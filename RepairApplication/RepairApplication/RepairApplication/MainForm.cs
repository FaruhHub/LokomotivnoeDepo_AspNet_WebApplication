using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RepairApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RepairGridView.DataSource = ConnectToBase.Depo.GetDepo();
            int id = int.Parse(dataGridView1.Rows[RepairGridView.CurrentRow.Index].Cells[0].Value.ToString());
            dataGridView1.DataSource = ConnectToBase.Depo.GetLokomotiv(id);
        }

        private void PersonGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // try
           // {
           //     if (checkBox1.Checked)
           //     {
           //         int id = int.Parse(PersonGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
           //         InfodataGridView.DataSource = ConnectLib.Person.GetPersonsInfo(id);
          //      }
          //  }
          //  catch (Exception ex)
          //  {

          //  }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
         //   try
           // {
            //    if (checkBox1.Checked)
            //    {
            //        int id = int.Parse(PersonGridView.Rows[PersonGridView.CurrentRow.Index].Cells[0].Value.ToString());
            //        InfodataGridView.DataSource = ConnectLib.Person.GetPersonsInfo(id);
                    
            //    }
            //    else
            //    {
           //         InfodataGridView.DataSource = null;
                    
           //     }
          //  }
          //  catch (Exception ex)
         //   {

         //   }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(RepairGridView.Rows[RepairGridView.CurrentRow.Index].Cells[0].Value.ToString());
                BrigadaForm work = new BrigadaForm(id);
                work.ShowDialog();
            }
            catch (Exception)
            {
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            //int idr = int.Parse(dataGridView1.Rows[PersonGridView.CurrentRow.Index].Cells[0].Value.ToString());
            //Analytics add = new Analytics(idr);
            //int idr = int.Parse(dataGridView1.Rows[PersonGridView.CurrentRow.Index].Cells[0].Value.ToString());
           // Analytics add = new Analytics();
            //add.ShowDialog();
            try
            {
                //int id = int.Parse(PersonGridView.Rows[PersonGridView.CurrentRow.Index].Cells[0].Value.ToString());
                Analytics add = new Analytics();
                add.ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }




        private void MainForm_Activated(object sender, EventArgs e)
        {
            RepairGridView.DataSource = ConnectToBase.Depo.GetDepo();
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RepairGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    int id = int.Parse(RepairGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    dataGridView1.DataSource = ConnectToBase.Depo.GetLokomotiv(id);
                }
            }
            catch (Exception)
            {

            }
        }



        

        private void InfodataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e, int idr)
        {
            //try
            //{
            //    string id = Convert.ToString(InfodataGridView.Rows[e.RowIndex].Cells[0].Value);
           //     InfodataGridView.DataSource = ConnectLib.Work.GetArchive(id);
           // }
           // catch (Exception)
           // {

           // }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int id = int.Parse(InfodataGridView.Rows[PersonGridView.CurrentRow.Index].Cells[0].Value.ToString());
            //    Analytics work = new Analytics(id);
            //    work.ShowDialog();
            //}
            //catch (Exception)
            //{
            //}
        }

        private void button7_Click(object sender, EventArgs e)
        {


        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Repair add = new Repair();
            add.ShowDialog();
        }
        


    }
}
