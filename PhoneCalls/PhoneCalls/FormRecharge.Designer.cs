namespace PhoneCalls
{
    sealed partial class FormRecharge
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxNumberToRecharge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxRechargeSum = new System.Windows.Forms.TextBox();
            this.btnMyNumb = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAccept.Location = new System.Drawing.Point(436, 306);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 41);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone number: ";
            // 
            // txtbxNumberToRecharge
            // 
            this.txtbxNumberToRecharge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtbxNumberToRecharge.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbxNumberToRecharge.Location = new System.Drawing.Point(183, 86);
            this.txtbxNumberToRecharge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxNumberToRecharge.MaxLength = 10;
            this.txtbxNumberToRecharge.Name = "txtbxNumberToRecharge";
            this.txtbxNumberToRecharge.Size = new System.Drawing.Size(162, 30);
            this.txtbxNumberToRecharge.TabIndex = 5;
            this.txtbxNumberToRecharge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtbxNumberToRecharge_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the amount of the recharge:";
            // 
            // txtbxRechargeSum
            // 
            this.txtbxRechargeSum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtbxRechargeSum.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbxRechargeSum.Location = new System.Drawing.Point(337, 158);
            this.txtbxRechargeSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxRechargeSum.MaxLength = 5;
            this.txtbxRechargeSum.Name = "txtbxRechargeSum";
            this.txtbxRechargeSum.Size = new System.Drawing.Size(162, 30);
            this.txtbxRechargeSum.TabIndex = 7;
            this.txtbxRechargeSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtbxNumberToRecharge_KeyPress);
            // 
            // btnMyNumb
            // 
            this.btnMyNumb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMyNumb.Location = new System.Drawing.Point(352, 84);
            this.btnMyNumb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMyNumb.Name = "btnMyNumb";
            this.btnMyNumb.Size = new System.Drawing.Size(114, 34);
            this.btnMyNumb.TabIndex = 8;
            this.btnMyNumb.Text = "My number";
            this.btnMyNumb.UseVisualStyleBackColor = true;
            this.btnMyNumb.Click += new System.EventHandler(this.BtnMyNumb_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(337, 306);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 41);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FormRecharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(572, 359);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMyNumb);
            this.Controls.Add(this.txtbxRechargeSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbxNumberToRecharge);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRecharge";
            this.Text = "Recharge";

        }

        #endregion
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxNumberToRecharge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxRechargeSum;
        private System.Windows.Forms.Button btnMyNumb;
        private System.Windows.Forms.Button btnBack;
    }
}