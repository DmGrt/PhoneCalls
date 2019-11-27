namespace PhoneCalls
{
    partial class FormBlock
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
            this.btnAddBlock = new System.Windows.Forms.Button();
            this.txtBoxAddBlock = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstBoxBlocked = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            // 
            // btnAddBlock
            // 
            this.btnAddBlock.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBlock.Location = new System.Drawing.Point(272, 51);
            this.btnAddBlock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddBlock.Name = "btnAddBlock";
            this.btnAddBlock.Size = new System.Drawing.Size(75, 32);
            this.btnAddBlock.TabIndex = 0;
            this.btnAddBlock.Text = "Add";
            this.btnAddBlock.UseVisualStyleBackColor = true;
            this.btnAddBlock.Click += new System.EventHandler(this.BtnAddBlock_Click);
            // 
            // txtBoxAddBlock
            // 
            this.txtBoxAddBlock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxAddBlock.Location = new System.Drawing.Point(25, 51);
            this.txtBoxAddBlock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxAddBlock.MaxLength = 10;
            this.txtBoxAddBlock.Name = "txtBoxAddBlock";
            this.txtBoxAddBlock.Size = new System.Drawing.Size(205, 27);
            this.txtBoxAddBlock.TabIndex = 2;
            this.txtBoxAddBlock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxAddBlock_KeyPress);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(272, 365);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 32);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lstBoxBlocked
            // 
            this.lstBoxBlocked.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstBoxBlocked.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstBoxBlocked.FormattingEnabled = true;
            this.lstBoxBlocked.ItemHeight = 23;
            this.lstBoxBlocked.Location = new System.Drawing.Point(25, 134);
            this.lstBoxBlocked.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstBoxBlocked.Name = "lstBoxBlocked";
            this.lstBoxBlocked.Size = new System.Drawing.Size(205, 257);
            this.lstBoxBlocked.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(272, 134);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Black list:";
            // 
            // FormBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstBoxBlocked);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtBoxAddBlock);
            this.Controls.Add(this.btnAddBlock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBlock";
            this.Text = "Block";
            this.Load += new System.EventHandler(this.FormBlock_Load);

        }

        #endregion

        private System.Windows.Forms.Button btnAddBlock;
        private System.Windows.Forms.TextBox txtBoxAddBlock;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstBoxBlocked;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
    }
}