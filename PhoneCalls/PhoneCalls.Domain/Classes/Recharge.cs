namespace PhoneCalls.Domain.Classes
{
    public class Recharge
    {
        public Recharge(int sumToRecharge, User currentUser)
        {
            this.sumToRecharge = sumToRecharge;
            this.User = currentUser;
        }

        private int sumToRecharge;
        private User User;


        public void RechargeBill()
        {
            if (sumToRecharge > 0)
            {
                User.RechargeBalance(sumToRecharge);
            }
        }
    }
}
