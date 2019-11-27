using System;
using System.Windows.Forms;
using PhoneCalls.Domain.Classes;

namespace PhoneCalls
{
    public sealed partial class FormRecharge : Form
    {
        private User User;
        public FormRecharge(User user)
        {
            InitializeComponent();
            User = user;
            BackgroundImage = Properties.Resources.rechargeBack;
        }
        
        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxRechargeSum.Text) || string.IsNullOrWhiteSpace(txtbxNumberToRecharge.Text))
            {
                MessageBox.Show(@"Fill in all the fields");
            }
            else
            {
                if (txtbxNumberToRecharge.TextLength != 10)
                {
                    MessageBox.Show(@"Wrong number format!");
                }
                else
                {
                    var number = txtbxNumberToRecharge.Text;
                    var sumToRecharge = Convert.ToInt32(txtbxRechargeSum.Text);
                    if (number == User.Number)
                    {
                        var recharge = new Recharge(sumToRecharge, User);
                        recharge.RechargeBill();
                    }
                    var home = new FormHome(User);
                    home.Show();
                    Hide();
                }
            }
        }

        private void TxtbxNumberToRecharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void BtnMyNumb_Click(object sender, EventArgs e)
        {
            txtbxNumberToRecharge.Text = User.Number;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            var home = new FormHome(User);
            home.Show();
            Close();
        }
    }
}
