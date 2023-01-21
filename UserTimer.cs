using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGameOfLife
{
    public partial class UserTimer : Form
    {
        public static UserTimer instance3;
        private int _timerInterval;
        public int timerInterval
        {
            get { return _timerInterval; }
            set { _timerInterval = value; }
        }
        public UserTimer()
        {
            InitializeComponent();
            instance3 = this;
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 1000;
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 1;
            trackBar1.TickFrequency = 1;
            trackBar1.ValueChanged += new EventHandler(trackBar1_ValueChanged);
        }
        public void trackBar1_ValueChanged(Object sender, EventArgs e)
        {
            if (trackBar1.Value == 0)
            {
                _timerInterval = 1;
            }
            else
            {
                _timerInterval = trackBar1.Value;
            }
            Form1.timerInterval = trackBar1.Value;
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Ok_Click(object sender, EventArgs e)
        {
            //This should change the timer interval in Form1
            Form1 form1 = Form1.instance1;
            form1.timer.Interval = timerInterval;
            this.Close();
        }

        private void trackBar1_MouseMove(object sender, MouseEventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            int tickPos = trackBar.Value;
            label2.Text = tickPos.ToString() + "ms";
        }
    }
}