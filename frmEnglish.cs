using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace MyTimer
{

    public partial class frmEnglish : Form
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


            // lblStopWatch.Text = Setting.strStopWatch();//Defalut Value 

            Setting.RestartStopWatchValue(StopWatchtimer, btnLap, btnStopStart, listView1, lblStopWatch);


        }

        //Defalut lap timer values
        void RestartLapTimerValue()
        {

            //Make all lap values  0
            Setting.RestartLaps();
            lblLap.Text = Setting.strLap();

            Laptimer.Enabled = false;//Stop lap timer

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

            Setting.ChangeStopWatchButtonsFunciotn((Button)sender, btnLap);


            if (btnStopStart.Text == "Stop")
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

            if (btnLap.Text == "Reset")
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



        //string FileName = @"C:\Users\Hp\source\repos\MyTimer\button_data.txt";
        bool PostionsIsFull = false, Blinking = true;
        byte btnNumber = 0;
        short[] arrXPostion = { 0, 80, 160, 240, 320, 605, 685, 765, 845, 925 };
        bool[] arrEmptyOrFull = { true, true, true, true, true, true, true, true, true, true };
        short X = 0;
        struct stButtonDetails
        {
            public string Text;
            public string Tag;
            public short XLocation;
        }
        List<Button> PresentTimerList = new List<Button>();
        List<stButtonDetails> buttonDetails = new List<stButtonDetails>();
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
            for (byte i = 0; i < arrEmptyOrFull.Length; i++)
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

        void button_Click(object sender, EventArgs e)
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
                MessageBox.Show("Buttons is Full", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            button.Name = "btnPresentTimer" + (btnNumber + 1);
            PresentTimerList.Add(button);//Add new button to list

            SaveButtonData(button);//Save Button Details






        }

        void SaveButtonData(Button btn)
        {
            string ButtonDetails = btn.Text + "/***/" + btn.Tag.ToString().PadLeft(2, '0') + "/***/" + btn.Location.X.ToString().PadLeft(3, '0');
            // File.AppendAllText(FileName, ButtonDetails);
            stButtonDetails Details;
            Details.Text = btn.Text;
            Details.Tag = btn.Tag.ToString();
            Details.XLocation = (short)btn.Location.X;
            buttonDetails.Add(Details);
            // string configFilePath = System.Reflection.Assembly.GetEntryAssembly().Location + ".config";

            // // Open the configuration file
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection setting = config.AppSettings.Settings;

            // // Add a new key-value pair to the app settings section
            setting.Add(btn.Name, ButtonDetails);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            //setting.Remove("btnPresentTimer6");
            //config.Save(ConfigurationSaveMode.Modified);
            //ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            //// setting.Remove("btn2");

        }

        void UpdateButtonData(Button btn)
        {
            stButtonDetails Temp;
            for (int i = 0; i < buttonDetails.Count; i++)
            {

                if (btn.Tag.ToString() == buttonDetails[i].Tag.ToString())
                {

                    Temp = buttonDetails[i];
                    Temp.Text = btn.Text;
                    buttonDetails[i] = Temp;
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    KeyValueConfigurationCollection setting = config.AppSettings.Settings;

                    // // Add a new key-value pair to the app settings section
                    string ButtonDetails = btn.Text + "/***/" + btn.Tag.ToString().PadLeft(2, '0') + "/***/" + btn.Location.X.ToString().PadLeft(3, '0');
                    config.AppSettings.Settings[btn.Name].Value = ButtonDetails;
                    //setting.Remove(btn.Name);
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);



                    //string ButtonDetails = btn.Text + "/***/" + btn.Tag.ToString().PadLeft(2, '0') + "/***/" + btn.Location.X.ToString().PadLeft(3, '0');
                    //setting.Add(btn.Name, ButtonDetails);
                    //config.Save(ConfigurationSaveMode.Modified);
                    //ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);

                    break;
                }

            }

            //File.Delete(FileName);
            //foreach (stButtonDetails item in buttonDetails)
            //{
            //    string ButtonDetails = item.Text + "/***/" + item.Tag.ToString().PadLeft(2, '0') + "/***/" + item.XLocation.ToString().PadLeft(3, '0') + "\n";
            //    File.AppendAllText(FileName, ButtonDetails);
            //}



        }

        void DeleteButtonData(Button btn)
        {

            for (int i = 0; i < buttonDetails.Count; i++)
            {
                if (btn.Tag.ToString() == buttonDetails[i].Tag.ToString())
                {
                    buttonDetails.RemoveAt(i);
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    KeyValueConfigurationCollection setting = config.AppSettings.Settings;
                    setting.Remove(btn.Name);
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
                    break;
                }

            }


            //File.Delete(FileName);
            // foreach (stButtonDetails item in buttonDetails)
            // {
            //     string ButtonDetails = item.Text + "/***/" + item.Tag.ToString().PadLeft(2, '0') + "/***/" + item.XLocation.ToString().PadLeft(3, '0') + "\n";
            //     File.AppendAllText(FileName, ButtonDetails);
            // }
        }

        void LoadButtonData()
        {
            NameValueCollection appSetting = ConfigurationManager.AppSettings;
            for (int i = 1; i <= 10; i++)
            {
                string value = "btnPresentTimer" + i;
                if (appSetting[value] != null)
                {
                    Button button = new Button();
                    button.Text = appSetting[value].Substring(0, 8);
                    button.Location = new Point(Convert.ToInt16(appSetting[value].Substring(20, 3)), 80);
                    button.Size = new Size(65, 28);
                    button.BackColor = Color.White;
                    button.AutoSize = true;
                    panel2.Controls.Add(button);
                    //put index to button
                    if (appSetting[value][15].ToString() == "/") { button.Tag = appSetting[value].Substring(14, 1); }
                    else { button.Tag = appSetting[value].Substring(14, 2); }
                    button.Name = "btnPresentTimer" + (Convert.ToInt16(button.Tag) + 1);
                    arrEmptyOrFull[Convert.ToByte(button.Tag)] = false;
                    button.Click += new EventHandler(this.button_Click);
                    button.ContextMenuStrip = this.cmsPresntTimer;
                    PresentTimerList.Add(button);//Add new button to list
                    stButtonDetails stButtonDetails;
                    stButtonDetails.Text = button.Text;
                    stButtonDetails.Tag = button.Tag.ToString();
                    stButtonDetails.XLocation = (byte)button.Location.X;
                    buttonDetails.Add(stButtonDetails);
                }
                else
                    return;

            }
            /*            if (File.Exists(FileName))
              {
                  StreamReader reader = new StreamReader(FileName);
                  string Line = default;

                  while ((Line = reader.ReadLine()) != null)
                  {
                      RestoreButton(Line);

                  }
                  reader.Close();
              }*/
        }

        void RestoreButton(string btn)
        {

            Button button = new Button();
            button.Text = btn.Substring(0, 8);
            button.Location = new Point(Convert.ToInt16(btn.Substring(20, 3)), 80);
            button.Size = new Size(65, 28);
            button.BackColor = Color.White;
            button.AutoSize = true;
            panel2.Controls.Add(button);
            //put index to button
            if (btn[15].ToString() == "/") { button.Tag = btn.Substring(14, 1); }
            else { button.Tag = btn.Substring(14, 2); }
            button.Name = "btnPresentTimer" + (Convert.ToInt16(button.Tag) + 1);
            arrEmptyOrFull[Convert.ToByte(button.Tag)] = false;
            button.Click += new EventHandler(this.button_Click);
            button.ContextMenuStrip = this.cmsPresntTimer;
            PresentTimerList.Add(button);//Add new button to list
            stButtonDetails stButtonDetails;
            stButtonDetails.Text = button.Text;
            stButtonDetails.Tag = button.Tag.ToString();
            stButtonDetails.XLocation = (byte)button.Location.X;
            buttonDetails.Add(stButtonDetails);
            //NameValueCollection setting = ConfigurationManager.AppSettings;
            //string value = setting["btn1"];

            //if(btn.Substring(0, 8) == "00:00:23")
            //{
            //    Button button2 = new Button();
            //    button2.Text = value.Substring(0, 8);
            //    button2.Location = new Point(240, 80);
            //    button2.Size = new Size(65, 28);
            //    button2.BackColor = Color.White;
            //    button2.AutoSize = true;
            //    panel2.Controls.Add(button2);

            //}







        }

        public frmEnglish()
        {
            InitializeComponent();
            Setting.RestartValues(HoursUpDown, MinutesUpDown, SecondsUpDown, pbar);

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
            if (Setting.IsLast15Seconds())
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

        private void frmEnglish_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //The Clock
        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();

        }

        private void frmEnglish_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString(); //Date of today
            lblTime.Text = DateTime.Now.ToLongTimeString();
            tabControl1.SelectedIndex = 1;



            LoadButtonData();


        }

        //End Timer
        private void EndTimer_Tick(object sender, EventArgs e)
        {
            Setting.Sound++;
            if (Setting.Sound == 3)
            {
                AlarmSound.Stop();
                EndTimer.Enabled = false;
                Setting.Sound = 0;
            }

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

        //Add new present timer
        private void tsmAddPresentTimer_Click(object sender, EventArgs e)
        {

            Form frm = new frmAddTimer();
            frm.ShowDialog();

        }

        //Hide present timers
        private void tsmHidePresentTimer_Click(object sender, EventArgs e)
        {
            //Is list empty
            if (PresentTimerList.Count == 0)
            {

                tsmHidePresentTimer.Checked = false;
                return;
            }
            if (((ToolStripMenuItem)sender).Checked)//if the choice is checked
            {
                foreach (Button b in PresentTimerList)
                {
                    b.Visible = false;

                }
            }

            else //if the choice is  not checked
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

            var frm = new frmEditTimer();
            frm.ShowDialog();
            UpdateButtonData(btnToModifying);

        }

        //Delete present timer
        private void cmsDeletePresentTimer_Click(object sender, EventArgs e)
        {

            arrEmptyOrFull[Convert.ToByte(btnToModifying.Tag)] = true;
            panel2.Controls.Remove(btnToModifying);
            PostionsIsFull = false;
            DeleteButtonData(btnToModifying);


        }

        //Delete all present timers
        private void tsmDeleteAllPresentTimers_Click(object sender, EventArgs e)
        {

            foreach (Button b in PresentTimerList)
            {
                panel2.Controls.Remove(b);
            }
            PresentTimerList.Clear();//Clear Present Timer List
            RemovePlaces();//Clear Places
                           //  File.Delete(FileName);//Clear File
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection setting = config.AppSettings.Settings;
            setting.Clear();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);


        }

        //Find context menu caller
        private void cmsPresntTimer_Opening(object sender, CancelEventArgs e)
        {
            btnToModifying = (Button)((ContextMenuStrip)sender).SourceControl;

        }

        //Hide uncesseary options
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
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
        //Allow to user to change application language
        private void tsmChangeToArabic_Click(object sender, EventArgs e)
        {

            Application.Restart();



        }

    }

}


