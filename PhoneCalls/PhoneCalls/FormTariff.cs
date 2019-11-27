using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PhoneCalls.Domain.Classes;

namespace PhoneCalls
{
    public sealed partial class FormTariff : Form
    {
        private List<Tariff> tariffsList = new List<Tariff>();
        private User User;
        private int _index;


        public FormTariff(User user)
        {
            InitializeComponent();
            BackgroundImage = Properties.Resources.callBack;
            User = user;

            if (User is UserVip)
            {
                var family = new Tariff("Family Vip", 90, 0.01, 50, 3600, 500, 150);
                var superNet = new Tariff("Super Net Vip", 200, 0.001, 100, 20000, 1000, 150);
                var extra = new Tariff("Extra Vip", 300, 0.0015, 140, 30000, 1500, 150);
                var def = new Tariff("Default Vip", 500, 0.015, 10, 300, 250, 150);
                tariffsList.Add(family);
                tariffsList.Add(superNet);
                tariffsList.Add(extra);
                tariffsList.Add(def);
                listBox1.DataSource = tariffsList;
            }
            else
            {
                var family = new Tariff("Family", 80, 0.02, 5, 60, 50, 30);
                var superNet = new Tariff("Super Net", 185, 0.005, 10, 200, 100, 30);
                var extra = new Tariff("Extra", 180, 0.0075, 14, 300, 150, 30);
                var def = new Tariff("Default", 50, 0.03, 1, 30, 250, 30);
                tariffsList.Add(family);
                tariffsList.Add(superNet);
                tariffsList.Add(extra);
                tariffsList.Add(def);
                listBox1.DataSource = tariffsList;
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _index = listBox1.SelectedIndex;
            LoadListBox(_index);
        }

        private void LoadListBox(int index)
        {
            listBox2.Items.Clear();
            listBox2.Items.Add(PrintTariffName(tariffsList[index]));
            listBox2.Items.Add(PrintTariffPrice(tariffsList[index]));
            listBox2.Items.Add(PrintTariffNet(tariffsList[index]));
            listBox2.Items.Add(PrintTariffMin(tariffsList[index]));
            listBox2.Items.Add(PrintTariffSms(tariffsList[index]));
            listBox2.Items.Add(PrintTariffDuration(tariffsList[index]));
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormHome home = new FormHome(User);
            home.Show();
            this.Hide();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            ChangeTariff change = new ChangeTariff(User, tariffsList[_index]);
            if (change.CheckChange())
            {
                FormHome home = new FormHome(User);
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(@"Not enougth money!!!");
                FormRecharge recharge = new FormRecharge(User);
                recharge.Show();
                this.Hide();
            }
        }

        public string PrintTariffPrice(Tariff tariff)
        {
            return "Price " + tariff.Price + " UAH ";
        }

        public string PrintTariffNet(Tariff tariff)
        {
            return "Internet: " + tariff.GbOfNet + " Gb ";
        }

        public string PrintTariffMin(Tariff tariff)
        {
            return tariff.MinOfCall + " min to other operators ";
        }

        public string PrintTariffSms(Tariff tariff)
        {
            return tariff.SmsNum + " SMS";
        }

        public string PrintTariffDuration(Tariff tariff)
        {
            return "Duration: " + tariff.DurationDays + " days";
        }

        public string PrintTariffName(Tariff tariff)
        {
            return tariff.Name;
        }
    }
}
