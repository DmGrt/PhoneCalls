using PhoneCalls.Domain.Classes;
using System;
using System.Linq;
using System.Windows.Forms;


namespace PhoneCalls
{
    public sealed partial class FormBlock : Form
    {
        private User User;

        public FormBlock(User user)
        {
            InitializeComponent();
            User = user;
            BackgroundImage = Properties.Resources.blockBack;
        }

        private void BtnAddBlock_Click(object sender, EventArgs e)
        {
            if (txtBoxAddBlock.TextLength != 10)
            {
                MessageBox.Show(@"Unkorrect number format!");
            }
            else
            {
                var numberToBlock = txtBoxAddBlock.Text;
                var block = new Block(User, numberToBlock);
                if (!block.IsBlocked() && numberToBlock != User.Number)
                {
                    block.BlockUser();
                    MessageBox.Show(@"Number blocked successfully");
                    txtBoxAddBlock.Clear();
                    lstBoxBlocked.Items.Add(numberToBlock);
                }
                else
                {
                    MessageBox.Show(@"You can't block it");
                    txtBoxAddBlock.Clear();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var selectedItem = lstBoxBlocked.SelectedItem.ToString();
            var block = new Block(User, selectedItem);
            block.UnblockUser();
            foreach (var s in lstBoxBlocked.SelectedItems.OfType<string>().ToList())
            {
                lstBoxBlocked.Items.Remove(s);
            }
        }

        private void TxtBoxAddBlock_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormBlock_Load(object sender, EventArgs e)
        {
            if (User != null) lstBoxBlocked.Items.AddRange(User.BlockedNumbers.ToArray());
        }
    }
}