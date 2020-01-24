using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeroKey
{
    class Stage
    {
        private int num;

        private Panel pnLamp;
        private Button btnStop;

        private RunStage handleRun;
        private StopStage handleStop;


        public Stage(int number, Panel panel, Button button, RunStage eventRun, StopStage eventStop)
        {
            num = number;

            pnLamp = panel;
            btnStop = button;

            btnStop.Click += Stop;

            handleRun = eventRun;
            handleStop = eventStop;
        }


        public void Run()
        {
            if (btnStop.Enabled) return;

            if (handleRun(num))
            {
                pnLamp.BackColor = System.Drawing.Color.Chartreuse;
                btnStop.Enabled = true;
            }
        }


        public void Stop(object sender, EventArgs e)
        {
            Stop();
        }


        public void Stop()
        {
            if (!btnStop.Enabled) return;

            if (handleStop(num))
            {
                pnLamp.BackColor = System.Drawing.Color.DarkGray;
                btnStop.Enabled = false;
            }
        }
    }
}
