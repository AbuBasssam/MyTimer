using CircularProgressBar;
using MyTimer.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTimer
{
    class clsFormSetting
    {
        
        //________________________________________
            // Stop Watch
        //________________________________________
        public byte LapNumber { set; get; }

        clsStopWatch StopWatch = new clsStopWatch();

        //Chanage button Functionality
        public void ChangeStopWatchButtonsFunciotn(Button btnStopStart, Button btnLap, bool Arabic = false)
        {
            if (Arabic)
            {

                if (btnStopStart.Text == "ابدأ")
                {
                    btnStopStart.Text = "إيقاف";
                    btnStopStart.BackColor = Color.Red;
                    btnLap.Text = "جولة";
                    btnLap.BackColor = Color.Cyan;


                }
                else
                {
                    btnStopStart.Text = "ابدأ";
                    btnStopStart.BackColor = Color.Green;
                    btnLap.Text = "إعادة";
                    btnLap.BackColor = Color.Black;
                }

            }
            else
            {
                if (btnStopStart.Text == "Start")
                {
                    btnStopStart.Text = "Stop";
                    btnStopStart.BackColor = Color.Red;
                    btnLap.Text = "Lap";
                    btnLap.BackColor = Color.Cyan;


                }
                else
                {
                    btnStopStart.Text = "Start";
                    btnStopStart.BackColor = Color.Green;
                    btnLap.Text = "Reset";
                    btnLap.BackColor = Color.Black;
                }
            }
        }

        //Restart defalut values
        public void RestartStopWatchValue(Timer StopWatchtimer, Button btnLap, Button btnStopStart, ListView listView1, Label lblStopWatch, bool Arabic = false)
        {

            if (Arabic)
            {

                StopWatchtimer.Enabled = false;//Clear Timer
                lblStopWatch.Text = StopWatch.strStopWatch();//Defalut Value 
                btnLap.Enabled = false; //switch off a button
                btnLap.BackColor = Color.Cyan;
                btnLap.Text = "جولة";

                btnStopStart.BackColor = Color.Green;
                btnStopStart.Text = "ابدأ";

                listView1.Items.Clear(); //Clear History
                LapNumber = 0;//Clear laps number
                
            }
            else
            {

                StopWatchtimer.Enabled = false;//Clear Timer
                lblStopWatch.Text = StopWatch.strStopWatch();//Defalut Value 
                btnLap.Enabled = false; //switch off a button
                btnLap.BackColor = Color.Cyan;
                btnLap.Text = "Lap";

                btnStopStart.BackColor = Color.Green;
                btnStopStart.Text = "Start";

                listView1.Items.Clear(); //Clear History
                LapNumber = 0;//Clear laps number
            }
        }
        
        public string strStopWatch()
        {
            return StopWatch.strStopWatch();
        }

        public void RestartStopWatch()
        {
            StopWatch.RestartStopWatch();
        }
        
        public void NewLap()
        {
             StopWatch.NewLap();
        }
        
        public void RestartLaps()
        {
            StopWatch.RestartLaps();
        }

        public string strLap()
        {
            return StopWatch.strLap();
        }
        
        public void Lap()
        {
            StopWatch.Lap();
        }
       
        public void Stopwatch()
        {
            StopWatch.Stopwatch();
        }

        public short BestLapValue()
        {
            return StopWatch.BestLapValue();
        }
        public short WorstLapValue()
        {
            return StopWatch.WorstLapValue();
        }


        



        //________________________________________


        //________________________________________
        //Timer 
        //________________________________________
        ClsTimer Mytimer = new ClsTimer();

        

        public byte Sound {  get; set; }
       
        //Keep or Hide some options  
        public void DisableChoices(ToolStripMenuItem tsmAddPresentTimer, ToolStripMenuItem tsmHidePresentTimer, ToolStripMenuItem tsmShowClock, ToolStripMenuItem tsmDeleteAllPresentTimers)
        {
            tsmAddPresentTimer.Enabled = false;
            tsmHidePresentTimer.Enabled = false;
            tsmDeleteAllPresentTimers.Enabled = false;
            tsmShowClock.Enabled = false;

        }

        public void EnableeChoices(ToolStripMenuItem tsmAddPresentTimer, ToolStripMenuItem tsmHidePresentTimer, ToolStripMenuItem tsmShowClock, ToolStripMenuItem tsmDeleteAllPresentTimers)
        {
            tsmAddPresentTimer.Enabled = true;
            tsmHidePresentTimer.Enabled = true;
            tsmDeleteAllPresentTimers.Enabled = true;
            tsmShowClock.Enabled = true;
        }

        //Clear Postions

        //Hide Buttons
        public void HideButtons(Button btnStop, Button btnRestart, Button btnPlay,Panel panel2) {
            btnStop.Visible = true;
            btnRestart.Visible = true;
            btnPlay.Visible = true;
            panel2.Visible = false;
        }

        //Restart defalut vlaues
        public void RestartValues(NumericUpDown HoursUpDown, NumericUpDown MinutesUpDown, NumericUpDown SecondsUpDown,CircularProgressBar.CircularProgressBar pbar )
        {
            Mytimer.RestartTimer();

            HoursUpDown.Value = 0;
            MinutesUpDown.Value = 0;
            SecondsUpDown.Value = 0;
            pbar.Value = 0;


            pbar.Text =
                       Mytimer.Hours.ToString().PadLeft(2, '0') + ":" +
                       Mytimer.Minutes.ToString().PadLeft(2, '0') + ":" +
                       Mytimer.Seconds.ToString().PadLeft(2, '0');

            pbar.ForeColor = Color.White;
            pbar.ProgressColor = Color.White;
            pbar.Maximum = 0;
            Sound = 0;
        }

        //Restart defalut Setting
        public void DefalutSetting(Timer ClockTimer, Timer BlinkingTmer ,Panel panel2 ,Button btnStop,Button btnRestart,Button btnPlay, CircularProgressBar.CircularProgressBar pbar,MenuStrip menuStrip1)
        {
            ClockTimer.Enabled = false;
            BlinkingTmer.Enabled = false;
            panel2.Visible = true;
            btnStop.Visible = false;
            btnRestart.Visible = false;
            btnPlay.Visible = false;
            pbar.Maximum = 0;
            menuStrip1.Enabled = true;
           

        }

        public byte HoursValue()
        {
            return Mytimer.Hours ;
        }
        public byte MinutesValue()
        {
            return Mytimer.Minutes;
        }
        public byte SecondsValue()
        {
            return Mytimer.Seconds ;
           
        }
        public void PrepareTimer()
        {
            Mytimer.PrepareTimer();
            
        }
        //Fill bar value
        public void DeterminedPbarValue(CircularProgressBar.CircularProgressBar pbar)
        {
            Mytimer.DeterminedTimerValue();

            pbar.Maximum = Mytimer.ValueOfTimer();
            pbar.Value = pbar.Maximum;
            pbar.ProgressColor = Color.Green;
            pbar.ForeColor = Color.Green;
        }
        public string strTimer()
        {
            return Mytimer.strTimer();
        }

        public void Hours(byte Hours)
        {
             Mytimer.Hours=Hours;
        }
        public void Minutes(byte Minutes)
        {
             Mytimer.Minutes = Minutes;
        }
        public void Seconds(byte Seconds)
        {
             Mytimer.Seconds = Seconds;
            
        }
        public void StartTimer()
        {
            Mytimer.StartTimer();
        }

        public bool IsLast30Seconds()
        {
            return Mytimer.IsLast30Seconds();
        }
        public bool IsLast15Seconds()
        {
            return Mytimer.IsLast15Seconds();
        }

        public bool IsTimerValueOut()
        {
            return Mytimer.IsTimerValueOut();
        }

        
        //________________________________________
    }
}
