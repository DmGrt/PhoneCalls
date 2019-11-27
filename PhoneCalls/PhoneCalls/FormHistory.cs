using System;
using System.Windows.Forms;
using PhoneCalls.Domain.Classes;

namespace PhoneCalls
{
    public sealed partial class FormHistory : Form
    {
        private User User;
        public FormHistory(User user)
        {
            InitializeComponent();
            BackgroundImage = Properties.Resources.mainBack;
            User = user;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome(User);
            formHome.Show();
            this.Hide();
        }

        private string printNumb(Call call)
        {
            return "Call to number: " + call.NumbToCall;
        }

        private string printDuration(Call call)
        {
            return "Duration: " + call.Duration.TotalSeconds.ToString("F2") + "sec";
        }
        private string printCost(Call call)
        {
            return "Cost: " + call.Cost.ToString("F2");
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            foreach (var hist in User.History.CallHistory)
            {
                lstHistory.Items.Add(printNumb(hist));
                lstHistory.Items.Add(printDuration(hist));
                lstHistory.Items.Add(printCost(hist));
                lstHistory.Items.Add("--------------------");
            }
        }
    }
}
