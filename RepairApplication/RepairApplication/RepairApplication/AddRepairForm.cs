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
    public partial class AddRepairForm : Form
    {
        public AddRepairForm()
        {
            InitializeComponent();
        }

        private void AddPersonForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {         
                ConnectToBase.Depo.AddRepair(
                    textBox1.Text.ToString(),
                    Convert.ToDouble(textBox2.Text),
                    Convert.ToBoolean(textBox3.Text),
                    Convert.ToInt32(textBox4.Text),
                    DateTime.Parse(textBox5.Text),
                    DateTime.Parse(textBox6.Text),
                    textBox7.Text.ToString(),
                    Convert.ToInt32(textBox8.Text),
                    Convert.ToInt32(textBox9.Text)
                    );
                MessageBox.Show("Человек добавлен в базу");
                this.Close();
        }







    }
}
