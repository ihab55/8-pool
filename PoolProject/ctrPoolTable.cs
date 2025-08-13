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
    public partial class ctrPoolTable : UserControl
    {
        public class CompletedEventArgs : EventArgs
        {
            public string TimeText { get; }
            public int TimeInSeconds { get; }
            public float RatePerHour { get; }
            public float TotalFees { get; }
            public CompletedEventArgs(string timeText, int timeInSeconds, float ratePerHour, float totalFees)
            {
                TimeText = timeText;
                TimeInSeconds = timeInSeconds;
                RatePerHour = ratePerHour;
                TotalFees = totalFees;
            }
        }
        [Category("Custom Events"), Description("Event raised when the table session ends.")]
        public event EventHandler<CompletedEventArgs> EndTable;
        public ctrPoolTable()
        {
            InitializeComponent();
        }
        [Category("Custom Properties"),Description("Table Name")]
        public string TableName
        {
            get { return grpTable.Text; }
            set { grpTable.Text = value; }
        }
        [Category("Custom Properties"), Description("Player Name")]
        public string PlayerName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        private float _HourlyRate = 10.0f;
        [Category("Custom Properties"), Description("Player Score")]
        public float HourlyRate
        {
            set { _HourlyRate = value; }
            get { return _HourlyRate; }
        } 

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pool;
            if (btnStartStop.Text == "Start")
            {
                btnStartStop.Text = "Stop";
                timer1.Start();
            }
            else
            {
                btnStartStop.Text = "Start";
                timer1.Stop();
            }
        }
        private int _seconds = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ++_seconds;
            TimeSpan timeSpan = TimeSpan.FromSeconds(_seconds);
            lblTime.Text = string.Format(@"{0:D2}:{1:D2}:{2:D2}", 
                timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnStartStop.Text = "Start";
            pictureBox1.Image = Properties.Resources.diablepool;
            float totalFees = ((float)_seconds /60/ 60)  * _HourlyRate;
            EndTable?.Invoke(this, new CompletedEventArgs(lblTime.Text, _seconds, HourlyRate, totalFees));
            _seconds = 0;
            lblTime.Text = string.Format(@"{0:D2}:{1:D2}:{2:D2}",
                0, 0, 0);
        }
    }
}
