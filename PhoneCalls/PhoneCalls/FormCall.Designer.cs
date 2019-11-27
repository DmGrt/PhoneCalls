namespace PhoneCalls
{
    sealed partial class FormCall
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
            this.btnHold = new System.Windows.Forms.Button();
            this.btnCall = new System.Windows.Forms.Button();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictBoxOff = new System.Windows.Forms.PictureBox();
            this.pictBoxOn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            // 
            // btnHold
            // 
            this.btnHold.Enabled = false;
            this.btnHold.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHold.Location = new System.Drawing.Point(112, 504);
            this.btnHold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(75, 34);
            this.btnHold.TabIndex = 1;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.BtnHold_Click);
            // 
            // btnCall
            // 
            this.btnCall.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCall.Location = new System.Drawing.Point(112, 449);
            this.btnCall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(75, 34);
            this.btnCall.TabIndex = 2;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.BtnCall_Click);
            // 
            // btnDismiss
            // 
            this.btnDismiss.Enabled = false;
            this.btnDismiss.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDismiss.Location = new System.Drawing.Point(238, 504);
            this.btnDismiss.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(75, 34);
            this.btnDismiss.TabIndex = 3;
            this.btnDismiss.Text = "Dismiss";
            this.btnDismiss.UseVisualStyleBackColor = true;
            this.btnDismiss.Click += new System.EventHandler(this.BtnDismiss_Click);
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxInput.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxInput.Location = new System.Drawing.Point(93, 400);
            this.txtBoxInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxInput.MaxLength = 10;
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(240, 30);
            this.txtBoxInput.TabIndex = 5;
            this.txtBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(171, 354);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(94, 28);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "00:00:00";
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(238, 449);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 34);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(340, 504);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 34);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pictBoxOff
            // 
            this.pictBoxOff.BackColor = System.Drawing.Color.Transparent;
            this.pictBoxOff.Location = new System.Drawing.Point(17, 374);
            this.pictBoxOff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictBoxOff.Name = "pictBoxOff";
            this.pictBoxOff.Size = new System.Drawing.Size(70, 70);
            this.pictBoxOff.TabIndex = 10;
            this.pictBoxOff.TabStop = false;
            this.pictBoxOff.Visible = false;
            // 
            // pictBoxOn
            // 
            this.pictBoxOn.BackColor = System.Drawing.Color.Transparent;
            this.pictBoxOn.Location = new System.Drawing.Point(339, 374);
            this.pictBoxOn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictBoxOn.Name = "pictBoxOn";
            this.pictBoxOn.Size = new System.Drawing.Size(70, 70);
            this.pictBoxOn.TabIndex = 8;
            this.pictBoxOn.TabStop = false;
            this.pictBoxOn.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(65, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(427, 551);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictBoxOff);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pictBoxOn);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.btnDismiss);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.btnHold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCall";
            this.Text = "CallForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();

        }

        #endregion

        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Button btnDismiss;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictBoxOn;
        private System.Windows.Forms.PictureBox pictBoxOff;
        private System.Windows.Forms.Button btnBack;
    }
}