using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGameOfLife
{
    public partial class Resume : Form
    {
        private ProgressBar _progressBar;
        private Timer timer;
        private Label _label;
        private DateTime startDate = new DateTime(2022, 5, 30);
        private DateTime endDate = new DateTime(2024, 8, 31);
        public Resume()
        {
            InitializeComponent();
            _progressBar = new ProgressBar();
            this._progressBar.ForeColor = Color.Orange;
            _progressBar.Minimum = 0;
            _progressBar.Maximum = (int)(endDate - startDate).TotalDays;
            _progressBar.Step = 1;
            _progressBar.Dock = DockStyle.Bottom;
            _progressBar.Margin = new Padding(20, 0, 20, 20);
            _progressBar.Width = this.Width - (_progressBar.Margin.Left + _progressBar.Margin.Right);
            this.Controls.Add(_progressBar);
            this.Resize += new EventHandler(Resume_Resize);

            _label = new Label();
            _label.AutoSize = true;
            _label.Font = new Font("Times New Roman", 10);
            _label.Dock = DockStyle.Bottom;
            _label.Margin = new Padding(20, 0, 20, 20);
            this.Controls.Add(_label);

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }
        private void Resume_Resize(object sender, EventArgs e)
        {
            _progressBar.Width = this.Width - (_progressBar.Margin.Left + _progressBar.Margin.Right);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            var currentDate = DateTime.Now;
            if (currentDate < startDate || currentDate > endDate)
            {
                timer.Stop();
                MessageBox.Show("Congratulations!!!");
                return;
            }
            int daysLeft = (int)(endDate - currentDate).TotalDays;
            _label.Text = daysLeft + " days left until graduation";
            _progressBar.Value = (int)(currentDate - startDate).TotalDays;
        }

        private void GOL_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
