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
    public partial class BrigadaForm : Form
    {
        public BrigadaForm(int id)
        {
            InitializeComponent();
            brigadadataGridView.DataSource = ConnectToBase.Brigada.GetBrigads(id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
