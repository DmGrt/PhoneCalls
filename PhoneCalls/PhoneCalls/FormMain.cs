using System;
using System.Windows.Forms;
using PhoneCalls.Domain.Classes;

namespace PhoneCalls
{
    public sealed partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            BackgroundImage = Properties.Resources.mainBack;
        }

        private void TxtbxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            var numb = e.KeyChar;

            if (char.IsDigit(numb) && numb != 8)
            {
                e.Handled = true;
            }
        }

        private void Btn_confrim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxName.Text) || string.IsNullOrWhiteSpace(txtbxNumber.Text))
            {
                MessageBox.Show(@"Fill in all the fields");
            }
            else
            {
                if (txtbxNumber.TextLength != 10)
                {
                    MessageBox.Show(@"Unkorrect number format!");
                }
                else
                {
                    var name = txtbxName.Text;
                    var number = txtbxNumber.Text;
                    var tariff = new Tariff("Default", 0, 0.5, 0, 30, 5, 30);
                    var user = new User(name, number, tariff);
                    user.ChangeMelody(Ringtones.Ivo_Bobul_Unknown.ToString());
                    var home = new FormHome(user);
                    home.Show();
                    Hide();
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtbxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}