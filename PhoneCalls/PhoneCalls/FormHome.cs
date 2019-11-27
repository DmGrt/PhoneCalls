using System;
using System.Globalization;
using System.Windows.Forms;
using PhoneCalls.Domain.Classes;


namespace PhoneCalls
{
    public sealed partial class FormHome : Form
    {
        public History History { get; }
        private User _user;
        public FormHome() { }
        public FormHome(User currentUser)
        {
            InitializeComponent();
            BackgroundImage = Properties.Resources.mainBack;
            txtbxCongr.Text = currentUser.Name;
            txtbxNumber.Text = currentUser.Number;
            txtbxBalance.Text = Convert.ToString(currentUser.Balance, CultureInfo.InvariantCulture);
            if (currentUser.Tariff != null)
                txtBxTariff.Text = currentUser.Tariff.ToString();
            else
                txtBxTariff.Text = @"NONE";
            _user = currentUser;
        }

        public FormHome(User currentUser, History history)
        {
            History = history;
            InitializeComponent();
            _user = currentUser;
        }

        private void BtnRecharge_Click(object sender, EventArgs e)
        {
            var replenish = new FormRecharge(_user);
            replenish.Show();
            Hide();
        }

        private void BtnBlock_Click(object sender, EventArgs e)
        {
            var block = new FormBlock(_user);
            block.Show();
        }

        private void BtnCall_Click(object sender, EventArgs e)
        {
            if (_user is UserVip)
            {
                _user.ChangeMelody(cmbRingtone.SelectedItem.ToString()); 
            }
            var callForm = new FormCall(_user);
            callForm.Show();
            Hide();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnChangeTariff_Click(object sender, EventArgs e)
        {
            FormTariff formTariff = new FormTariff(_user);
            formTariff.Show();
            Hide();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            if (_user is UserVip)
            {
                btnVIP.Visible = false;
                btnInfoVIP.Visible = false;
                cmbRingtone.Visible = true;
                cmbRingtone.DataSource = Enum.GetValues(typeof(Ringtones));
            }
            txtbxCongr.Text = _user.Name;
            txtbxNumber.Text = _user.Number;
            txtbxBalance.Text = _user.Balance.ToString("F2"); 
            if (_user.Tariff != null)
                txtBxTariff.Text = _user.Tariff.ToString();
            else
                txtBxTariff.Text = @"NONE";
            btnVIP.BackgroundImage = Properties.Resources.VIP;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            FormHistory formHistory = new FormHistory(_user);
            formHistory.Show();
            Hide();
        }

        private void btnVIP_Click(object sender, EventArgs e)
        {
            if (_user.CanUpgradeToVip())
            {
                _user.UpgradeToVip();
                _user = new UserVip(_user.Name, _user.Number, _user.Tariff, _user.Balance, _user.BlockedNumbers, _user.History);
                btnVIP.Hide();
                btnInfoVIP.Hide();
                cmbRingtone.Visible = true;
                MessageBox.Show(@"Now you can choose melody in Call", @"Congrat's!!!");
                FormHome_Load(sender,e);
            }
        }

        private void btnInfoVIP_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"You can become one of our VIP clients. " + @"\n" + @"We'll' increase every your replenishment on 25%" +@"\n"+@" It will cost 500 UAH", @"Info");
        }

        private void cmbRingtone_SelectedIndexChanged(object sender, EventArgs e)
        {
            _user.ChangeMelody(cmbRingtone.SelectedItem.ToString());
        }
    }
}
