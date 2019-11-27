using System;

namespace PhoneCalls.Domain.Classes
{
    public class Call
    {
        public Call(User user, string numbToCall)
        {
            this.User = user;
            this.NumbToCall = numbToCall;
        }

        private DateTimeOffset _dateStart, _dateEnd;
        public TimeSpan Duration { get; private set; }
        public double Cost { get; private set; }
        private User User { get; }
        public bool IsCallActive { get; private set; }
        public string NumbToCall;

        public void EndCall()
        {
            IsCallActive = false;
            _dateEnd = DateTimeOffset.Now;
            Duration = _dateEnd - _dateStart;
        }

        public void EndByEmptyBill()
        {
            IsCallActive = false;
            _dateEnd = DateTimeOffset.Now;
            Duration = _dateEnd - _dateStart;
        }

        public void StartCall()
        {
            _dateStart = DateTimeOffset.Now;
        }

        public bool TryHandleCurrentMoment()
        {
            bool handled;
            if (User.CanChargeBalance(User.Tariff.PricePerSec))
            {
                Cost += User.Tariff.PricePerSec;
                User.ChargeBalance(User.Tariff.PricePerSec);
                handled = true;
            }
            else
            {
                handled = false;
            }
            return handled;
        }

    }
}

