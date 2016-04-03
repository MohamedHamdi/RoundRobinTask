using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundRobinTask
{
    class Process
    {
        public string processName;
        public int LastEnd;
        public int count = 0;
        public int burstTime;
        public int arrival;
        public int turnAround;
        public int reminder;
        public int waiting = 0;
        public int start;

        public Process(string name,int arr,int bur)
        {
            processName = name;
            arrival = arr;
            burstTime = bur;
            reminder = bur;
        }

    }
}
