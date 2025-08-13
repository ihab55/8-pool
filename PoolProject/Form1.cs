using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrPoolTable1_EndTable(object sender, ctrPoolTable.CompletedEventArgs e)
        {
            MessageBox.Show($"Time: {e.TimeText}\n" +
                                $"Total Fees: {e.TotalFees:C2}\n" +
                                $"Hourly Rate: {e.RatePerHour:C2}",
                                "Session Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
