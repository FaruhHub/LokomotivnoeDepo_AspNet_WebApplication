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
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();
            dataGridView2.DataSource = ConnectToBase.Brigada.GetMoneyByRepair();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
