using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace MyTimer
{

    class clsStopWatch
    {
        struct _stStopwatch
        {
            public byte MiliSeconds;
            public byte Seconds;
            public byte Minutes;
            public byte Hours;
        };

        _stStopwatch _Stopwatch;
        _stStopwatch _LapStopwatch;
        List<_stStopwatch> LapList = new List<_stStopwatch>();

        static short _BestLap = 0, _WorstLap = 0;

        void _StopWatch(ref _stStopwatch StopWach)
        {
            StopWach.MiliSeconds++;
            if (StopWach.MiliSeconds == 100)
            {
                StopWach.MiliSeconds = 0;
                StopWach.Seconds++;
            }
            if (StopWach.Seconds == 60)
            {
                StopWach.Seconds = 0;
                StopWach.Minutes++;
            }

            if (StopWach.Minutes == 60)
            {
                StopWach.Minutes = 0;
                StopWach.Hours++;
            }

            if (_StopwatchLimit())
            {
                NewLap();
                RestartStopWatch();
            }

        }

        bool _StopwatchLimit()
        {

            return (_Stopwatch.Hours == 48) ? true : false;

        }

        bool _IsStopwatch1BeforeStopwatch2(_stStopwatch stopwatch1, _stStopwatch stopwatch2)
        {
            return (stopwatch1.Hours < stopwatch2.Hours) ? true :
                   (stopwatch1.Hours > stopwatch2.Hours) ? false :
                   (stopwatch1.Minutes < stopwatch2.Minutes) ? true :
                   (stopwatch1.Minutes > stopwatch2.Minutes) ? false :
                   (stopwatch1.Seconds < stopwatch2.Seconds) ? true :
                   (stopwatch1.Seconds > stopwatch2.Seconds) ? false :
                    stopwatch1.MiliSeconds < stopwatch2.MiliSeconds;
        }

        bool _IsStopwatch1EqualStopwatch2(_stStopwatch stopwatch1, _stStopwatch stopwatch2)
        {
            return (stopwatch1.Hours == stopwatch2.Hours) ?
                   (stopwatch1.Minutes == stopwatch2.Minutes) ?
                   (stopwatch1.Seconds == stopwatch2.Seconds) ?
                   (stopwatch1.MiliSeconds == stopwatch2.MiliSeconds) ? true : false : false : false : false;
        }
        void _BestRecourd()
        {
            if (_IsFirstLap())
            {
                _BestLap = (short)LapList.Count;
                return;
            }
            if (LapList.Count == 2)
            {
                if (_IsStopwatch1BeforeStopwatch2(_LapStopwatch, LapList[0]) && !_IsStopwatch1EqualStopwatch2(_LapStopwatch, LapList[0]))
                {

                    _BestLap = (short)LapList.Count;
                    _WorstLap = (short)(LapList.Count - 1);
                }
                else
                {
                    _WorstLap = (short)LapList.Count;
                }
            }
            else
            {
                if (_IsStopwatch1BeforeStopwatch2(_LapStopwatch, LapList[_BestLap - 1]) && !_IsStopwatch1EqualStopwatch2(_LapStopwatch, LapList[_BestLap - 1]))
                {

                    _BestLap = (short)LapList.Count;

                }
                if (_IsStopwatch1BeforeStopwatch2(LapList[_WorstLap - 1], _LapStopwatch) && !_IsStopwatch1EqualStopwatch2(LapList[_WorstLap - 1], _LapStopwatch))
                {
                    _WorstLap = (short)LapList.Count;
                }

            }
        }

        public clsStopWatch()
        {

        }

        public void RestartStopWatch()
        {
            _Stopwatch.MiliSeconds = 0;
            _Stopwatch.Seconds = 0;
            _Stopwatch.Minutes = 0;
            _Stopwatch.Hours = 0;
        }

        public void NewLap()
        {
            LapList.Add(_LapStopwatch);
            _BestRecourd();
            _LapStopwatch.Hours = 0;
            _LapStopwatch.Minutes = 0;
            _LapStopwatch.Seconds = 0;
            _LapStopwatch.MiliSeconds = 0;

        }
        public void RestartLaps()
        {
            _LapStopwatch.Hours = 0;
            _LapStopwatch.Minutes = 0;
            _LapStopwatch.Seconds = 0;
            _LapStopwatch.MiliSeconds = 0;
            _BestLap = 0;
            _WorstLap = 0;
            LapList.Clear();
        }

        public void Stopwatch()
        {
            _StopWatch(ref _Stopwatch);
        }

        public void Lap()
        {

            _StopWatch(ref _LapStopwatch);

        }

        public string strStopWatch()
        {
            if (_Stopwatch.Hours > 0)
            {
                return _Stopwatch.Hours.ToString().PadLeft(2, '0') +
                       _Stopwatch.Minutes.ToString().PadLeft(2, '0') + ":" +
                       _Stopwatch.Seconds.ToString().PadLeft(2, '0') + "." +
                       _Stopwatch.MiliSeconds.ToString().PadLeft(2, '0');

            }

            return _Stopwatch.Minutes.ToString().PadLeft(2, '0') + ":" +
                   _Stopwatch.Seconds.ToString().PadLeft(2, '0') + "." +
                   _Stopwatch.MiliSeconds.ToString().PadLeft(2, '0');
        }

        public string strLap()
        {
            if (_LapStopwatch.Hours > 0)
            {
                return _LapStopwatch.Hours.ToString().PadLeft(2, '0') +
                       _LapStopwatch.Minutes.ToString().PadLeft(2, '0') + ":" +
                       _LapStopwatch.Seconds.ToString().PadLeft(2, '0') + "." +
                       _LapStopwatch.MiliSeconds.ToString().PadLeft(2, '0');

            }

            return _LapStopwatch.Minutes.ToString().PadLeft(2, '0') + ":" +
                       _LapStopwatch.Seconds.ToString().PadLeft(2, '0') + "." +
                       _LapStopwatch.MiliSeconds.ToString().PadLeft(2, '0');
        }

        bool _IsFirstLap()
        {
            return (LapList.Count == 1);
        }

        public short BestLapValue()
        {
            return _BestLap;
        }

        public short WorstLapValue()
        {
            return _WorstLap;
        }



    }
}










   
