using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class Sms
    {
        public string Number { get; set; }
        public bool Delivered { get; set; }
        public bool Checked { get; set; }
        public string Text { get; set; }

        public Sms()
        {
            Delivered = false;
            Checked = false;
        }
    }

    class SmsLog
    {
        public const int MAX = 5;
        public List<Sms> SmsHistory { get;}

        public SmsLog()
        {
            SmsHistory = new List<Sms>();
        }

        public void AddHistory(Sms sms)
        {
            if (sms != null)
            {
                if (SmsHistory.Count == MAX)
                {
                    SmsHistory.RemoveAt(0);
                }  
                SmsHistory.Add(sms);               
            }
        }

        public bool DeleteSmm(string number)
        {
            List<Sms> temp = new List<Sms>();
            foreach (var item in SmsHistory)
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

            foreach (var sms in temp)
            {
                SmsHistory.Remove(sms);
            }
            return true;
        }

        public int Count()
        {
            return SmsHistory.Count();
        }

        public int Count(string number)
        {
            int count = 0;
            foreach (var sms in SmsHistory)
            {
                if (sms.Number == number)
                {
                    count++;
                }
            }
            return count;
        }

        public void DeleteHystory()
        {
            SmsHistory.Clear();
        }

    }
}
