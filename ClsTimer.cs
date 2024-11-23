using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTimer
{
     class ClsTimer
     {
        ushort TimerValue = 0;

        bool ExtraSeconds = false;
        
        public byte Hours
        {
            get;
            set;
        }
        
        public byte Minutes
        {
            get;
            set;
        }
        
        public byte Seconds
        {
            get;
            set;
        }
        
        public ClsTimer(byte Hours,byte Minutes,byte Seconds)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
            this.Seconds = Seconds;
           DeterminedTimerValue();
        }
       
        public ClsTimer(byte Minutes, byte Seconds)
        {
            this.Hours = 0;
            this.Minutes = Minutes;
            this.Seconds = Seconds;
            DeterminedTimerValue();
        }
       
        public ClsTimer( byte Seconds)
        {
            this.Hours = 0;
            this.Minutes = 0;
            this.Seconds = Seconds;
            DeterminedTimerValue();
        }
       
        public ClsTimer()
        {
            this.Hours = 0;
            this.Minutes = 0;
            this.Seconds = 0;
            
        }

        public int ValueOfTimer()
        {
            return TimerValue;
        }

        //Calculate Timer Value
        public void DeterminedTimerValue()
        {

            TimerValue = (ushort)((3600 * Hours) + (60 * Minutes) + (Seconds));
           
            
        }

        //Edit minutes each Round
        public void MinutesEditor()
        {
            TimerValue--;
            if (Minutes > 0)
            {
                Minutes--;
                Seconds = 59;

            }
            else
            {
                Seconds = 59;
            }
            


        }

        //Edit Hours each 60 Round
        public void HoursEditor()
        {
            if (Hours == 1)
            {

                if (Minutes == 0)
                {
                    Hours--;
                    Minutes = 59;
                    Seconds = 59;


                }

                else
                {

                    MinutesEditor();

                }
            }



            else
            {

                if (Minutes == 0)
                {
                    Hours--;
                    Minutes = 59;
                    Seconds = 59;


                }
                else
                {
                    MinutesEditor();

                }
            }


        }

        public bool IsTimerValueOut()
        {
            return (TimerValue==0)? true:false;
        }
        
        public bool IsLast30Seconds()
        {

            return (TimerValue <= 30) ? true : false;
        }

        public bool IsLast15Seconds()
        {
            return (TimerValue <= 15) ? true : false;
        }
        
        public void PrepareTimer()
        {
            


            ////Turn shorter timer
            if (Seconds> 0)
            {
                //check for extra seconds
                if (Hours > 0 || Minutes > 0)
                {
                    ExtraSeconds = true;
                }

                Task.Delay(1000);

            }
            
            else if (Hours> 0)
            {
                
                HoursEditor();
                Task.Delay(1000);
            }
            
            else
            {
                
                MinutesEditor();
                Task.Delay(1000);
            }
        }
       
        public void StartTimer()
        {

            //Check extra seconds
            if (ExtraSeconds)
            {
                Seconds--;
                TimerValue--;
                if (Seconds == 0)
                {
                    ExtraSeconds = false;

                    if (Hours > 0)
                    {

                        HoursEditor();
                        Task.Delay(1000);
                    }
                    else
                    {
                        MinutesEditor();
                        Task.Delay(1000);
                    }
                    return;
                }
                return;
            }



            Seconds--;
            TimerValue--;

            //Start new Round
            if (Seconds == 0 && TimerValue != 0)
            {


                if (Hours > 0)
                {
                    HoursEditor();
                    Task.Delay(1000);
                   
                }
                else
                {
                    MinutesEditor();
                    Task.Delay(1000);
                    
                }

                return;
            }
        }

        public void RestartTimer()
        {
            Hours= 0;
            Minutes= 0;
            Seconds = 0;
            DeterminedTimerValue();
        }
        
        public string strTimer()
        {
          if (Hours == 0)
          {
           
            return 
                  Minutes.ToString().PadLeft(2, '0') + ":" +
                  Seconds.ToString().PadLeft(2, '0');
          }
            return Hours.ToString().PadLeft(2, '0') + ":" +
                   Minutes.ToString().PadLeft(2, '0') + ":" +
                   Seconds.ToString().PadLeft(2, '0');
        }
     }
}
