namespace PhoneCalls.Domain.Classes
{
    public class ChangeTariff
    {
        public ChangeTariff(User currentUser, Tariff tariff)
        {
            this.User = currentUser;
            this.tariff = tariff;
        }

        private User User;
        private Tariff tariff;

        public bool CheckChange()
        {
            if (User.Balance >= tariff.Price)
            {
                User.ChangeTariff(tariff);
                User.ChargeBalance(tariff.Price);
                return true;
            }
            else
                return false;
        }
    }
}
