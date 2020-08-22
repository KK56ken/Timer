using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class TimerClass : Form
    {
        public TimerClass()
        {
            InitializeComponent();
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.IsStopWatch)
            {
                timer1.second += 1;
                if(timer1.second == 60)
                {
                    timer1.second = 0;
                    timer1.minute += 1;
                }
                if(timer1.minute == 60)
                {
                    timer1.minute = 0;
                    timer1.hour += 1;
                }
                TimeLabel.Text = timer1.hour.ToString() + "時" + timer1.minute.ToString() + "分" + timer1.second.ToString() + "秒";
            }
            //一番最初に実行される
            else if (!timer1.IsStopWatch)
            {
                string time;
                DateTime data = DateTime.Now;
                time = data.Hour.ToString() + "時" + data.Minute.ToString() + "分" + data.Second.ToString() + "秒";
                
                TimeLabel.Text = time;
                titlelabel.Text = "時刻";
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void swich_Click(object sender, EventArgs e)
        {
            if (timer1.IsStopWatch)
            {
                timer1.Start();
                timer1.hour = 0;
                timer1.minute = 0;
                timer1.second = 0;

                timer1.IsStopWatch = false;
                titlelabel.Text = "時刻";

                string time;
                DateTime data = DateTime.Now;
                time = data.Hour.ToString() + "時" + data.Minute.ToString() + "分" + data.Second.ToString() + "秒";

                TimeLabel.Text = time;

                swShow(timer1.IsStopWatch);
            }
            else if (!timer1.IsStopWatch)
            {
                timer1.Stop();

                TimeLabel.Text = timer1.hour.ToString() + "時" + timer1.minute.ToString() + "分" + timer1.second.ToString() + "秒";
                timer1.IsStopWatch = true;
                titlelabel.Text = "ストップウォッチ";

                swShow(timer1.IsStopWatch);
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            timer1.hour = 0;
            timer1.minute = 0;
            timer1.second = 0;
            TimeLabel.Text = timer1.hour.ToString() + "時" + timer1.minute.ToString() + "分" + timer1.second.ToString() + "秒";
        }
        private void swShow(bool display)
        {
            if (display)
            {
                start.Visible = true;
                stop.Visible = true;
                reset.Visible = true;
                
            }
            else if(!display)
            {
                start.Visible = false;
                stop.Visible = false;
                reset.Visible = false;
            }
        }
    }
}
