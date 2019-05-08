using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone phone = new MobilePhone()
            {
                Provider = "ArmPhone",
                Model = "TSD Octa A0520P",
                RamMemory = 4,
                RomMemory = 64
            };

            Sms sms1 = new Sms()
            {
                Number = "111111",
                Delivered = true,
                Checked = true,
                Text = "Hello"
            };

            Sms sms2 = new Sms()
            {
                Number = "222222",
                Delivered = true,
                Checked = false,
                Text = "Hello"
            };

            Sms sms3 = new Sms()
            {
                Number = "333333",
                Delivered = false,
                Checked = false,
                Text = "Hello"
            };

            Sms sms4 = new Sms()
            {
                Number = "444444",
                Delivered = true,
                Checked = false,
                Text = "Hello"
            };

            Sms sms5 = new Sms()
            {
                Number = "555555",
                Delivered = true,
                Checked = false,
                Text = "Hello"
            };

            Sms[] allSms = { sms1, sms2, sms3, sms4, sms5 };
            foreach (var sms in allSms)
            {
                phone.SmsLog.AddHistory(sms);
            }

            foreach (var sms in phone.SmsLog.SmsHistory)
            {
                Console.WriteLine(sms.Number);
            }
            Console.WriteLine();

            phone.SmsLog.AddHistory(new Sms { Number = "666666", Delivered = true, Checked = true, Text = "Hello"});
            foreach (var sms in phone.SmsLog.SmsHistory)
            {
                Console.WriteLine(sms.Number);
            }

        }
    }
}
