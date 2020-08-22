using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public partial class MyTime : System.Windows.Forms.Timer
    {
        public bool IsStopWatch = false;

        public int minute;
        public int second;
        public int hour;

        public MyTime()
        {
            InitializeComponent();
        }

        public MyTime(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
