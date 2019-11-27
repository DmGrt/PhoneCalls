using System.Collections.Generic;

namespace PhoneCalls.Domain.Classes
{
    public class UserVip : User
    {
        public UserVip(string name, string number, Tariff tariff, double balance, List<string> blockedNumbers, History history) 
            : base(name, number, tariff)
        {
            Balance = balance;
            BlockedNumbers = blockedNumbers;
            History = history;
            Ringtone = Ringtones.Viktor_Pavlik_Shikidim.ToString();
        }

        public override void RechargeBalance(double sum)
        {
            if(sum > 0) 
                Balance += sum * 1.05;
        }

        public override bool CanChargeBalance(double sum)
        {
            return Balance - sum >= -100;
        }

        public override bool IsHaveCredit()
        {
            return Balance < 0;
        }

        public override void ChangeMelody(string value)
        {
            Ringtone = value;
        }
    }
}
