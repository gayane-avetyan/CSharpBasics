using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class MobilePhone
    {
        public string Model { get; set; }
        public string Provider { get; set; }
        public int RamMemory { get; set; }
        public int RomMemory { get; set; }
        public CallLog CallLog { get; set; }
        public SmsLog SmsLog { get; set; }

        public MobilePhone()
        {
            CallLog = new CallLog();
            SmsLog = new SmsLog();
        }
    }
}
