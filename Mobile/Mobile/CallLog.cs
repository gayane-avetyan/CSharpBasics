using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class Call
    {
        public DateTime date { get; set; }
        public int Duration { get; set; }
        public string Number { get; set; }
    }

    class CallLog
    {
        private List<Call> CallHistory { get; set; }

        public CallLog()
        {
            CallHistory = new List<Call>();
        }

        public void AddCall(Call call)
        {
            if (call != null)
            {
                CallHistory.Add(call);
            }
        }

        public bool DeleteCall(string number)
        {
            List<Call> temp = new List<Call>();
            foreach (var item in CallHistory)
            {
                if (item.Number == number)
                {
                    temp.Add(item);
                }
            }

            if (temp.Count == 0)
            {
                return false;
            }

            foreach (var call in temp)
            {
                CallHistory.Remove(call);
            }
            return true;
        }


        public int Count()
        {
            return CallHistory.Count();
        }

        public int Count(string number)
        {
            int count = 0;
            foreach (var call in CallHistory)
            {
                if (call.Number == number)
                {
                    count++;
                }
            }
            return count;
        }

        public void DeleteHystory()
        {
            CallHistory.Clear();
        }

        public int TotalDuration()
        {
            int total = 0;
            foreach (var call in CallHistory)
            {
                total += call.Duration;
            }
            return total;
        }

        public int LongestCall()
        {
            int longestCall = 0;
            foreach (var call in CallHistory)
            {
                if (call.Duration > longestCall)
                {
                    longestCall = call.Duration;
                }
            }
            return longestCall;
        }
    }   
}
