using MyTimer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTimer
{
    public partial class frmArabic : Form
    {

        clsFormSetting Setting = new clsFormSetting();

        //________________________________
        //Stopwatch Page
        //________________________________

        
        //Restart defalut values
        void RestartStopWatchValue()
        {
            //Make all values 0
            Setting.RestartStopWatch();
            RestartLapTimerValue(); //Defalut lap timer values


            //lblStopWatch.Text = Setting.strStopWatch();//Defalut Value 

            Setting.RestartStopWatchValue(StopWatchtimer, btnLap, btnStopStart, listView1, lblStopWatch,true);


        }

        //Defalut lap timer values
        void RestartLapTimerValue()
        {

            //Make all lap values  0
            Setting.NewLap();
            lblLap.Text = Setting.strLap();

            Laptimer.Enabled = false;//Stop lap timer


        }

        //Close the applicatoin
        private void ArabicForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Timer for each lap
        private void Laptimer_Tick(object sender, EventArgs e)
        {
            lblLap.Text = Setting.strLap();
            Setting.Lap();
        }

        //Start Timer
        private void btnStopStartWatch_Click(object sender, EventArgs e)
        {
            btnLap.Enabled = true;//Turn on button for the first time

            Setting.ChangeStopWatchButtonsFunciotn((Button)sender, btnLap,true);



            if (btnStopStart.Text == "إيقاف")
            {
                StopWatchtimer.Enabled = true;//Start timer
                Laptimer.Enabled = true;//Start count lap time
            }
            else
            {
                StopWatchtimer.Enabled = false;//Stop timer
                Laptimer.Enabled = false;//Stop count lap time


            }

        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            //Fill History Fields
            byte Lap = Convert.ToByte(Setting.LapNumber + 1);
            ListViewItem Item = new ListViewItem(Lap.ToString());
            Item.SubItems.Add(lblLap.Text);
            Item.SubItems.Add(lblStopWatch.Text);




            if (btnLap.Text == "إعادة")
            {
                RestartStopWatchValue();//Restart timer
            }

            else
            {

                //Add history to table
                listView1.Items.Add(Item);


                //Start new lap
                Setting.LapNumber++;
                Setting.NewLap();
              
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Text == Setting.BestLapValue().ToString()) { item.BackColor = Color.Green; }


                    else if (item.Text == Setting.WorstLapValue().ToString()) { item.BackColor = Color.Red; }


                    else { item.BackColor = Color.FromArgb(1, 17, 53); }

                }

                Laptimer.Enabled = true;

            }
        }

       //Timer clock
        private void StopWatchtimer_Tick(object sender, EventArgs e)
        {
            lblStopWatch.Text = Setting.strStopWatch();
            Setting.Stopwatch();
        }

        public frmArabic()
        {
            
            InitializeComponent();
            Setting.RestartValues(HoursUpDown, MinutesUpDown, SecondsUpDown, pbar);
        }

        //________________________________
        //Timer Page
        //________________________________

        bool PostionsIsFull = false, Blinking = true;
        byte btnNumber = 0;
        short[] arrXPostion = { 0, 80, 160, 240, 320, 605, 685, 765, 845, 925 };
        bool[] arrEmptyOrFull = { true, true, true, true, true, true, true, true, true, true };
        short X = 0;

        List<Button> PresentTimerList = new List<Button>();
        public static Button btnToModifying = new Button();
        SoundPlayer AlarmSound = new SoundPlayer(@"C:\Users\Hp\Downloads\Alarm.wav");
        
        //Clear Postions
        void RemovePlaces()
        {
            for (byte i = 0; i < arrEmptyOrFull.Length; i++)
            {
                arrEmptyOrFull[i] = true;
            }
        }
        //Get vertical Postion for created button 
        short GetXPostion()
        {
            for (byte i = (byte)(arrEmptyOrFull.Length-1); i >= 0; i--)
            {
                btnNumber = i;
                if (arrEmptyOrFull[i])
                {
                    arrEmptyOrFull[i] = false;
                    return arrXPostion[i];
                }
            }
            PostionsIsFull = true;
            return -1;
        }

        //Events for created buttons
        private void button_Click(object sender, EventArgs e)
    {


        Setting.Hours(Convert.ToByte(((Button)sender).Text.Substring(0, 2)));
        Setting.Minutes(Convert.ToByte(((Button)sender).Text.Substring(3, 2)));
        Setting.Seconds(Convert.ToByte(((Button)sender).Text.Substring(6, 2)));

        pbar.Text = Setting.strTimer();

        pbar.Refresh();
    }

        //Create button to present timer
        public void CreateButton(string MaskText)
        {
            X = GetXPostion();//return empty vertical postion

            //Check empty postion
            if (PostionsIsFull)
            {
                MessageBox.Show("لا يوجد اماكن فارغة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Button button = new Button();
            button.Text = MaskText;
            button.Location = new Point(X, 80);
            button.Size = new Size(65, 28);
            button.BackColor = Color.White;
            button.AutoSize = true;
            panel2.Controls.Add(button);
            button.Tag = btnNumber;  //put index to new button 
            button.Click += new EventHandler(this.button_Click);
            button.ContextMenuStrip = this.cmsPresntTimer;
            PresentTimerList.Add(button); //Add new button to list

        }
        
        private void NumreicalUpDown_ValueChanged(object sender, EventArgs e)
        {


            if ((NumericUpDown)sender == HoursUpDown)
            {
                Setting.Hours(Convert.ToByte(HoursUpDown.Value));

            }

            else if ((NumericUpDown)sender == MinutesUpDown)
            {
                Setting.Minutes(Convert.ToByte(MinutesUpDown.Value));
            }

            else
            {
                Setting.Seconds(Convert.ToByte(SecondsUpDown.Value));
            }


            pbar.Text =
               Setting.HoursValue().ToString().PadLeft(2, '0') + ":" +
               Setting.MinutesValue().ToString().PadLeft(2, '0') + ":" +
               Setting.SecondsValue().ToString().PadLeft(2, '0');




            pbar.Refresh();

        }

        //PLay timer
        private void btnStart_Click(object sender, EventArgs e)
        {

            if (pbar.Text == "00:00:00")
            {
                return;
            }

            Setting.DeterminedPbarValue(pbar);

            //Hide buttons
            Setting.HideButtons(btnStop, btnRestart, btnPlay, panel2);

            Setting.PrepareTimer();

            pbar.Text = Setting.strTimer();

            ClockTimer.Enabled = true;
            menuStrip1.Enabled = false;//Disable Setting menu

        }

        //Stop Timer
        private void btnStop_Click(object sender, EventArgs e)
        {
            ClockTimer.Enabled = false; 

        }
        
        //Replay timer
        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            ClockTimer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Setting.StartTimer();
            pbar.Value--;



            pbar.Text = Setting.strTimer();

            //Blinking Last 30 Seconds

            if (Setting.IsLast30Seconds())
            {
                BlinkingTmer.Enabled = true;
            }

            if (Setting.IsTimerValueOut())
            {

                Setting.RestartValues(HoursUpDown, MinutesUpDown, SecondsUpDown, pbar);
                Setting.DefalutSetting(ClockTimer, BlinkingTmer, panel2, btnStop, btnRestart, btnPlay, pbar, menuStrip1);

                EndTimer.Enabled = true;
                AlarmSound.Play();

                /*                notifyDone.Icon = SystemIcons.Application;

                 notifyDone.ShowBalloonTip(10000);
 */

                return;
            }



        }

        //Blinking timer
        private void BlinkingTmer_Tick(object sender, EventArgs e)
        {
            if (pbar.Value <= 15)
            {
                BlinkingTmer.Interval = 250;
            }


            if (Blinking)
            {
                pbar.ProgressColor = Color.Red;
                pbar.ForeColor = Color.Red;
                Blinking = false;
            }
            else
            {
                pbar.ProgressColor = Color.White;
                pbar.ForeColor = Color.White;
                Blinking = true;

            }
        }

        //Restart timer
        private void btnRestart_Click(object sender, EventArgs e)
        {
            Setting.RestartValues(HoursUpDown, MinutesUpDown, SecondsUpDown, pbar);
            Setting.DefalutSetting(ClockTimer, BlinkingTmer, panel2, btnStop, btnRestart, btnPlay, pbar, menuStrip1);


        }

        //Add new present timer
        private void tsmAddPresentTimer_Click(object sender, EventArgs e)
        {

            Form frm = new frmArabicAddTimer();
            frm.ShowDialog();

        }

        //Hide present timers
        private void tsmHidePresentTimer_Click(object sender, EventArgs e)
        {
            //Is list empty
            if (PresentTimerList.Count == 0) { return; }
            
            if (((ToolStripMenuItem)sender).Checked)//if the choice is checked
            {
                foreach (Button b in PresentTimerList)
                {
                    b.Visible = false;

                }
            }

            else  //if the choice is  not checked
            {
                foreach (Button b in PresentTimerList)
                {
                    b.Visible = true;

                }
            }
        }

        //Edit present timer
        private void cmsEditPresentTimer_Click(object sender, EventArgs e)
        {

            var frm = new frmArabicEditTimer();
            frm.ShowDialog();

        }

        //Delete present timer
        private void cmsDeletePresentTimer_Click(object sender, EventArgs e)
        {
            arrEmptyOrFull[Convert.ToByte(btnToModifying.Tag)] = true;//Make postion empty
            panel2.Controls.Remove(btnToModifying);//Remove it from Panel
            PostionsIsFull = false;


        }

        //Delete present timers
        private void tsmDeleteAllPresentTimers_Click(object sender, EventArgs e)
        {
           
            foreach (Button b in PresentTimerList)
            {

                panel2.Controls.Remove(b);
               
            }
            PresentTimerList.Clear();//Clear button list
            RemovePlaces();//Remove Places
        }
        
        //Find context menu caller
        private void cmsPresntTimer_Opening(object sender, CancelEventArgs e)
        {
            btnToModifying = (Button)((ContextMenuStrip)sender).SourceControl;

        }
        
        //Hide uncesseary options
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                // Enable the menu strip when the first tab is selected
                Setting.EnableeChoices(tsmAddPresentTimer, tsmHidePresentTimer, tsmShowClock, tsmDeleteAllPresentTimers);
                AcceptButton = btnStart;
            }
            else
            {
                // Disable the menu strip for other tabs
                Setting.DisableChoices(tsmAddPresentTimer, tsmHidePresentTimer, tsmShowClock, tsmDeleteAllPresentTimers);
                AcceptButton = btnStopStart;

            }
        }
        //End Timer
        private void EndTimer_Tick(object sender, EventArgs e)
        {
            Setting.Sound++;
            if (Setting.Sound == 3)
            {
                AlarmSound.Stop();
                EndTimer.Enabled = false;
                Setting.Sound=0;
            }

        }

        private void frmArabic_Load(object sender, EventArgs e)
        {
               lblDate.Text = DateTime.Now.ToShortDateString(); //Date of today
               lblTime.Text = DateTime.Now.ToLongTimeString();
               tabControl1.SelectedIndex = 1;
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void tsmShowClock_Click(object sender, EventArgs e)
        {
            if (tsmShowClock.Checked)
            {
                lblTime.Visible = false;
                lblDate.Visible = false;
                tsmShowClock.Checked = false;
            }
            else
            {
                lblTime.Visible = true;
                lblDate.Visible = true;
                tsmShowClock.Checked = true;



            }
        }

        //Allow to user to change application language
        private void tsmChangeToEnglish_Click(object sender, EventArgs e)
        {

            Application.Restart();



        }


    }
}
