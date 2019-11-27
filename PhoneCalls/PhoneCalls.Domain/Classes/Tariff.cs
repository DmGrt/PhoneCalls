namespace PhoneCalls.Domain.Classes
{
    public class Tariff
    {
        public Tariff(string name, int price, double pricePerSec, int gbOfNet, int minOfCall, int smsNum, int durationDays)
        {
            Name = name;
            Price = price;
            PricePerSec = pricePerSec;
            GbOfNet = gbOfNet;
            MinOfCall = minOfCall;
            SmsNum = smsNum;
            DurationDays = durationDays;
        }

        public string Name;
        public int Price;
        public double PricePerSec;
        public int GbOfNet;
        public int MinOfCall;
        public int SmsNum;
        public int DurationDays;

        public override string ToString()
        {
            return Name;
        }
    }
}
