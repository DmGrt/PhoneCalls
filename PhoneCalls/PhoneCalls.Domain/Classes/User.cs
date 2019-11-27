using System;
using System.Collections.Generic;

namespace PhoneCalls.Domain.Classes
{
    public class User : Person
    {
        public User(string name, string number, Tariff tariff) : base(name)
        {
            Name = name;
            Number = number;
            Balance = 0;
            BlockedNumbers = new List<string>(); // {"0508069936","4598263345" };
            Tariff = tariff;
            History = new History();
        }

        public string Number { get; }
        public double Balance { get; protected set; }
        public List<string> BlockedNumbers { get; protected set; }
        public Tariff Tariff { get; protected set; }
        public History History;
        public string Ringtone { get; protected set; }

        

        public virtual void RechargeBalance(double sum)
        {
            Balance += sum;
        }

        public virtual bool CanChargeBalance(double sum)
        {
            return Balance - sum >= 0;
        }

        public void ChargeBalance(double sum)
        {
            Balance -= sum;
        }

        public void ChangeTariff(Tariff tariff)
        {
            if (tariff != null)
                this.Tariff = tariff;
            else
                throw new ArgumentNullException($"null tariff");
        }

        public void AddToBlockList(string numbToBlock)
        {
            if (numbToBlock != null)
                BlockedNumbers.Add(numbToBlock);
            else
                throw new ArgumentNullException($"null numbToBlock");
        }

        public void RemoveFromBlockList(string numbToBlock)
        {
            if (numbToBlock != null)
                BlockedNumbers.Remove(numbToBlock);
            else
                throw new ArgumentNullException($"null numbToBlock");
        }

        public bool CanUpgradeToVip()
        {
            return Balance >= 500;
        }
        public virtual void ChangeMelody(string value)
        {
            Ringtone = Ringtones.Ivo_Bobul_Unknown.ToString();
        }
        public virtual bool IsHaveCredit()
        {
            return false;}
        public void UpgradeToVip()
        {
            this.ChargeBalance(500);
        }
        public bool CheckBlock(string numberToCheck)
        {
            var check = false;

            foreach (var blockedNumber in BlockedNumbers)
            {
                check = numberToCheck == blockedNumber;
            }

            return check;
        }
    }
}