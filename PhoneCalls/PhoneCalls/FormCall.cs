using System;
using System.Windows.Forms;
using PhoneCalls.Domain.Classes;
using WMPLib;

namespace PhoneCalls
{
    public sealed partial class FormCall : Form
    {
        private User User;
        private Call _call;
        private DateTime _dateStart;
        private Timer _timer;
        private long _tick;
        private string _melody;
        private WindowsMediaPlayer player = new WindowsMediaPlayer();


        public FormCall(User user)
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.Phone_img1;
            User = user;
            _melody = User.Ringtone;
            pictBoxOn.Image = Properties.Resources.loud;
            pictBoxOff.Image = Properties.Resources.offSound;
            BackgroundImage = Properties.Resources.callBack;
        }

        private void BtnCall_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxInput.Text) || string.IsNullOrWhiteSpace(txtBoxInput.Text))
            {
                MessageBox.Show(@"Fill in all the fields");
            }
            else
            {
                if (!User.CanChargeBalance(0))
                {
                    MessageBox.Show(@"You have no money! Please recharge your bill!");
                    ToHomeForm();
                }

                if (User is UserVip && User.IsHaveCredit())
                {
                    MessageBox.Show(@"You have some credit. Please recharge your balance before next call!");
                    ToHomeForm();
                }

                if (txtBoxInput.Text == User.Number)
                {
                    MessageBox.Show(@"Call yourself rly???");
                }
                else
                {
                    if (txtBoxInput.TextLength != 10)
                    {
                        MessageBox.Show(@"Uncorrected number format!");
                    }
                    else
                    {
                        if (User.CheckBlock(txtBoxInput.Text) == false)
                        {
                            _call = new Call(User, txtBoxInput.Text);
                            btnDismiss.Enabled = true;
                            btnBack.Enabled = false;
                            btnReset.Enabled = true;
                            pictBoxOn.Visible = true;
                            _dateStart = DateTime.Now;
                            _call.StartCall();
                            btnHold.Enabled = true;
                            btnCall.Enabled = false;
                            PlayMelody();
                            _timer = new Timer { Interval = 1000 };
                            _timer.Tick += TickTimer;
                            _timer.Start();
                        }
                        else
                        {
                            MessageBox.Show(@"This number is blocked by you!");
                        }
                    }
                }
            }
        }

        private void PlayMelody()
        {
            switch (_melody)
            {
                case "Verka_serduchka_Horosho":
                    player.URL = @"C:\Users\User\Desktop\PhoneCalls\PhoneCalls\Resources\Serduchka_Khorosho.mp3";
                    player.controls.play();
                    break;
                case "Oleg_Vinnik_Vovchitsya":
                    player.URL = @"C:\Users\User\Desktop\PhoneCalls\PhoneCalls\Resources\Vinnik_Vovchitsya.mp3";
                    player.controls.play();
                    break;
                case "Viktor_Pavlik_Shikidim":
                    player.URL = @"C:\Users\User\Desktop\PhoneCalls\PhoneCalls\Resources\Viktor_Pavlik_Shikidim.mp3";
                    player.controls.play();
                    break;
                case "Ivo_Bobul_Unknown":
                    player.URL = @"C:\Users\User\Desktop\PhoneCalls\PhoneCalls\Resources\Ivo_Bobul_Unknown.mp3";
                    player.controls.play();
                    break;
            }
        }


        private void TickTimer(object sender, EventArgs e)
        {
            _tick = DateTime.Now.Ticks - _dateStart.Ticks;
            var stopWatch = new DateTime();
            stopWatch = stopWatch.AddTicks(_tick);
            lblTimer.Text = $@"{stopWatch:HH:mm:ss}";

            if (!_call.TryHandleCurrentMoment())
            {
                if(User is UserVip)
                    player.controls.stop();
                _timer.Stop();
                _call.EndByEmptyBill();
                MessageBox.Show(@"You have no enough money on your bill");
                User.History.AddToHist(_call);
                ToHomeForm();
            }
        }

        private void BtnHold_Click(object sender, EventArgs e)
        {
            pictBoxOn.Visible = false;
            pictBoxOff.Visible = true;
            _timer.Enabled = false;
            _timer.Stop();
            if (User is UserVip)
                player.controls.pause();
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            pictBoxOn.Visible = true;
            pictBoxOff.Visible = false;
            _timer.Start();
            _timer.Enabled = true;
            if (User is UserVip)
                player.controls.play();
        }
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var numb = e.KeyChar;
            if (!char.IsDigit(numb) && numb != 8)
            {
                e.Handled = true;
            }
        }

        private void BtnDismiss_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _call.EndCall();
            User.History.AddToHist(_call);
            ToHomeForm();
            player.controls.stop();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ToHomeForm();
        }

        private void ToHomeForm()
        {
            var homeForm = new FormHome(User);
            homeForm.Show();
            Close();
        }
    }
}