namespace PhoneCalls
{
    sealed partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCall = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnReplenish = new System.Windows.Forms.Button();
            this.congrLabel = new System.Windows.Forms.Label();
            this.numbLabel = new System.Windows.Forms.Label();
            this.txtbxCongr = new System.Windows.Forms.TextBox();
            this.txtbxNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxBalance = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChangeTariff = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxTariff = new System.Windows.Forms.TextBox();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnVIP = new System.Windows.Forms.Button();
            this.btnInfoVIP = new System.Windows.Forms.Button();
            this.cmbRingtone = new System.Windows.Forms.ComboBox();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(433, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Here you can:";
            // 
            // btnCall
            // 
            this.btnCall.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCall.Location = new System.Drawing.Point(413, 123);
            this.btnCall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(100, 36);
            this.btnCall.TabIndex = 3;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.BtnCall_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBlock.Location = new System.Drawing.Point(522, 173);
            this.btnBlock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(99, 36);
            this.btnBlock.TabIndex = 4;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.BtnBlock_Click);
            // 
            // btnReplenish
            // 
            this.btnReplenish.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReplenish.Location = new System.Drawing.Point(416, 172);
            this.btnReplenish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReplenish.Name = "btnReplenish";
            this.btnReplenish.Size = new System.Drawing.Size(100, 38);
            this.btnReplenish.TabIndex = 5;
            this.btnReplenish.Text = "Recharge";
            this.btnReplenish.UseVisualStyleBackColor = true;
            this.btnReplenish.Click += new System.EventHandler(this.BtnRecharge_Click);
            // 
            // congrLabel
            // 
            this.congrLabel.AutoSize = true;
            this.congrLabel.BackColor = System.Drawing.Color.Transparent;
            this.congrLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.congrLabel.ForeColor = System.Drawing.Color.White;
            this.congrLabel.Location = new System.Drawing.Point(13, 68);
            this.congrLabel.Name = "congrLabel";
            this.congrLabel.Size = new System.Drawing.Size(36, 25);
            this.congrLabel.TabIndex = 6;
            this.congrLabel.Text = "Hi,";
            // 
            // numbLabel
            // 
            this.numbLabel.AutoSize = true;
            this.numbLabel.BackColor = System.Drawing.Color.Transparent;
            this.numbLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numbLabel.ForeColor = System.Drawing.Color.White;
            this.numbLabel.Location = new System.Drawing.Point(12, 152);
            this.numbLabel.Name = "numbLabel";
            this.numbLabel.Size = new System.Drawing.Size(132, 25);
            this.numbLabel.TabIndex = 7;
            this.numbLabel.Text = "Your number: ";
            // 
            // txtbxCongr
            // 
            this.txtbxCongr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtbxCongr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxCongr.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbxCongr.Location = new System.Drawing.Point(47, 69);
            this.txtbxCongr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxCongr.Name = "txtbxCongr";
            this.txtbxCongr.ReadOnly = true;
            this.txtbxCongr.Size = new System.Drawing.Size(223, 24);
            this.txtbxCongr.TabIndex = 8;
            // 
            // txtbxNumber
            // 
            this.txtbxNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtbxNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxNumber.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbxNumber.Location = new System.Drawing.Point(143, 154);
            this.txtbxNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxNumber.Name = "txtbxNumber";
            this.txtbxNumber.ReadOnly = true;
            this.txtbxNumber.Size = new System.Drawing.Size(125, 24);
            this.txtbxNumber.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Your balance:";
            // 
            // txtbxBalance
            // 
            this.txtbxBalance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtbxBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxBalance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbxBalance.Location = new System.Drawing.Point(168, 228);
            this.txtbxBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxBalance.Name = "txtbxBalance";
            this.txtbxBalance.ReadOnly = true;
            this.txtbxBalance.Size = new System.Drawing.Size(100, 24);
            this.txtbxBalance.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(463, 318);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 36);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnChangeTariff
            // 
            this.btnChangeTariff.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeTariff.Location = new System.Drawing.Point(416, 217);
            this.btnChangeTariff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangeTariff.Name = "btnChangeTariff";
            this.btnChangeTariff.Size = new System.Drawing.Size(204, 38);
            this.btnChangeTariff.TabIndex = 13;
            this.btnChangeTariff.Text = "Change tariff";
            this.btnChangeTariff.UseVisualStyleBackColor = true;
            this.btnChangeTariff.Click += new System.EventHandler(this.BtnChangeTariff_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Your tariff:";
            // 
            // txtBxTariff
            // 
            this.txtBxTariff.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBxTariff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxTariff.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBxTariff.Location = new System.Drawing.Point(168, 289);
            this.txtBxTariff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBxTariff.Name = "txtBxTariff";
            this.txtBxTariff.ReadOnly = true;
            this.txtBxTariff.Size = new System.Drawing.Size(100, 24);
            this.txtBxTariff.TabIndex = 15;
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistory.Location = new System.Drawing.Point(522, 123);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(100, 36);
            this.btnHistory.TabIndex = 16;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnVIP
            // 
            this.btnVIP.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVIP.Location = new System.Drawing.Point(416, 262);
            this.btnVIP.Name = "btnVIP";
            this.btnVIP.Size = new System.Drawing.Size(147, 38);
            this.btnVIP.TabIndex = 17;
            this.btnVIP.Text = "Become a VIP";
            this.btnVIP.UseVisualStyleBackColor = true;
            this.btnVIP.Click += new System.EventHandler(this.btnVIP_Click);
            // 
            // btnInfoVIP
            // 
            this.btnInfoVIP.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInfoVIP.Location = new System.Drawing.Point(569, 262);
            this.btnInfoVIP.Name = "btnInfoVIP";
            this.btnInfoVIP.Size = new System.Drawing.Size(48, 38);
            this.btnInfoVIP.TabIndex = 18;
            this.btnInfoVIP.Text = "i";
            this.btnInfoVIP.UseVisualStyleBackColor = true;
            this.btnInfoVIP.Click += new System.EventHandler(this.btnInfoVIP_Click);
            // 
            // cmbRingtone
            // 
            this.cmbRingtone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbRingtone.FormattingEnabled = true;
            this.cmbRingtone.Location = new System.Drawing.Point(414, 267);
            this.cmbRingtone.Name = "cmbRingtone";
            this.cmbRingtone.Size = new System.Drawing.Size(204, 28);
            this.cmbRingtone.TabIndex = 19;
            this.cmbRingtone.Visible = false;
            this.cmbRingtone.SelectedIndexChanged += new System.EventHandler(this.cmbRingtone_SelectedIndexChanged);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(671, 432);
            this.Controls.Add(this.cmbRingtone);
            this.Controls.Add(this.btnInfoVIP);
            this.Controls.Add(this.btnVIP);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.txtBxTariff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChangeTariff);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtbxBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxNumber);
            this.Controls.Add(this.txtbxCongr);
            this.Controls.Add(this.numbLabel);
            this.Controls.Add(this.congrLabel);
            this.Controls.Add(this.btnReplenish);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormHome_Load);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnReplenish;
        private System.Windows.Forms.Label congrLabel;
        private System.Windows.Forms.Label numbLabel;
        private System.Windows.Forms.TextBox txtbxCongr;
        private System.Windows.Forms.TextBox txtbxNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxBalance;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnChangeTariff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxTariff;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnVIP;
        private System.Windows.Forms.Button btnInfoVIP;
        private System.Windows.Forms.ComboBox cmbRingtone;
    }
}