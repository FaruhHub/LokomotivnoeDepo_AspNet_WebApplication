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
    public partial class Repair : Form
    {
        public Repair()
        {
            InitializeComponent();
            dataGridView1.DataSource = ConnectToBase.Brigada.GetRepair();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                dataGridView2.DataSource = ConnectToBase.Depo.GetRepairByName(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Введите значение");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRepairForm add = new AddRepairForm();
            add.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
