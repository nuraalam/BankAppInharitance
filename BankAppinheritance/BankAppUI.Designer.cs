namespace BankAppinheritance
{
    partial class BankAppUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.savingAccountNumberTextBox = new System.Windows.Forms.TextBox();
            this.savingAccountCreateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serviceChargeTextBox = new System.Windows.Forms.TextBox();
            this.cheeckingAccountNumberTextBox = new System.Windows.Forms.TextBox();
            this.cheeckingAccountCreateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.withdrawRadioButton = new System.Windows.Forms.RadioButton();
            this.depositeRadioButton = new System.Windows.Forms.RadioButton();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.doItButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.selectAccountComboBox = new System.Windows.Forms.ComboBox();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.interestRateTextBox);
            this.groupBox1.Controls.Add(this.savingAccountNumberTextBox);
            this.groupBox1.Controls.Add(this.savingAccountCreateButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saving Acoount";
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(119, 76);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(133, 20);
            this.interestRateTextBox.TabIndex = 2;
            // 
            // savingAccountNumberTextBox
            // 
            this.savingAccountNumberTextBox.Location = new System.Drawing.Point(118, 32);
            this.savingAccountNumberTextBox.Name = "savingAccountNumberTextBox";
            this.savingAccountNumberTextBox.Size = new System.Drawing.Size(134, 20);
            this.savingAccountNumberTextBox.TabIndex = 0;
            // 
            // savingAccountCreateButton
            // 
            this.savingAccountCreateButton.Location = new System.Drawing.Point(227, 110);
            this.savingAccountCreateButton.Name = "savingAccountCreateButton";
            this.savingAccountCreateButton.Size = new System.Drawing.Size(75, 23);
            this.savingAccountCreateButton.TabIndex = 3;
            this.savingAccountCreateButton.Text = "Create";
            this.savingAccountCreateButton.UseVisualStyleBackColor = true;
            this.savingAccountCreateButton.Click += new System.EventHandler(this.savingAccountCreateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interest Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.serviceChargeTextBox);
            this.groupBox2.Controls.Add(this.cheeckingAccountNumberTextBox);
            this.groupBox2.Controls.Add(this.cheeckingAccountCreateButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(373, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cheecking Account";
            // 
            // serviceChargeTextBox
            // 
            this.serviceChargeTextBox.Location = new System.Drawing.Point(111, 76);
            this.serviceChargeTextBox.Name = "serviceChargeTextBox";
            this.serviceChargeTextBox.Size = new System.Drawing.Size(134, 20);
            this.serviceChargeTextBox.TabIndex = 1;
            // 
            // cheeckingAccountNumberTextBox
            // 
            this.cheeckingAccountNumberTextBox.Location = new System.Drawing.Point(111, 31);
            this.cheeckingAccountNumberTextBox.Name = "cheeckingAccountNumberTextBox";
            this.cheeckingAccountNumberTextBox.Size = new System.Drawing.Size(134, 20);
            this.cheeckingAccountNumberTextBox.TabIndex = 0;
            // 
            // cheeckingAccountCreateButton
            // 
            this.cheeckingAccountCreateButton.Location = new System.Drawing.Point(200, 110);
            this.cheeckingAccountCreateButton.Name = "cheeckingAccountCreateButton";
            this.cheeckingAccountCreateButton.Size = new System.Drawing.Size(75, 23);
            this.cheeckingAccountCreateButton.TabIndex = 3;
            this.cheeckingAccountCreateButton.Text = "Create";
            this.cheeckingAccountCreateButton.UseVisualStyleBackColor = true;
            this.cheeckingAccountCreateButton.Click += new System.EventHandler(this.cheeckingAccountCreateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Service Charge";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.withdrawRadioButton);
            this.groupBox3.Controls.Add(this.depositeRadioButton);
            this.groupBox3.Controls.Add(this.amountTextBox);
            this.groupBox3.Controls.Add(this.doItButton);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(29, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 168);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction";
            // 
            // withdrawRadioButton
            // 
            this.withdrawRadioButton.AutoSize = true;
            this.withdrawRadioButton.Location = new System.Drawing.Point(141, 61);
            this.withdrawRadioButton.Name = "withdrawRadioButton";
            this.withdrawRadioButton.Size = new System.Drawing.Size(70, 17);
            this.withdrawRadioButton.TabIndex = 1;
            this.withdrawRadioButton.TabStop = true;
            this.withdrawRadioButton.Text = "Withdraw";
            this.withdrawRadioButton.UseVisualStyleBackColor = true;
            // 
            // depositeRadioButton
            // 
            this.depositeRadioButton.AutoSize = true;
            this.depositeRadioButton.Location = new System.Drawing.Point(52, 61);
            this.depositeRadioButton.Name = "depositeRadioButton";
            this.depositeRadioButton.Size = new System.Drawing.Size(67, 17);
            this.depositeRadioButton.TabIndex = 0;
            this.depositeRadioButton.TabStop = true;
            this.depositeRadioButton.Text = "Deposite";
            this.depositeRadioButton.UseVisualStyleBackColor = true;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(67, 84);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(177, 20);
            this.amountTextBox.TabIndex = 2;
            // 
            // doItButton
            // 
            this.doItButton.Location = new System.Drawing.Point(177, 123);
            this.doItButton.Name = "doItButton";
            this.doItButton.Size = new System.Drawing.Size(75, 23);
            this.doItButton.TabIndex = 3;
            this.doItButton.Text = "Do It";
            this.doItButton.UseVisualStyleBackColor = true;
            this.doItButton.Click += new System.EventHandler(this.doItButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Amount";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.displayTextBox);
            this.groupBox4.Controls.Add(this.displayButton);
            this.groupBox4.Location = new System.Drawing.Point(300, 253);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 168);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Information";
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(295, 19);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 23);
            this.displayButton.TabIndex = 0;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Select Account";
            // 
            // selectAccountComboBox
            // 
            this.selectAccountComboBox.FormattingEnabled = true;
            this.selectAccountComboBox.Items.AddRange(new object[] {
            "Saving Account",
            "Cheecking Account"});
            this.selectAccountComboBox.Location = new System.Drawing.Point(289, 207);
            this.selectAccountComboBox.Name = "selectAccountComboBox";
            this.selectAccountComboBox.Size = new System.Drawing.Size(166, 21);
            this.selectAccountComboBox.TabIndex = 5;
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(27, 61);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(343, 85);
            this.displayTextBox.TabIndex = 1;
            // 
            // BankAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 448);
            this.Controls.Add(this.selectAccountComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BankAppUI";
            this.Text = "BankAppUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.TextBox savingAccountNumberTextBox;
        private System.Windows.Forms.Button savingAccountCreateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox serviceChargeTextBox;
        private System.Windows.Forms.TextBox cheeckingAccountNumberTextBox;
        private System.Windows.Forms.Button cheeckingAccountCreateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton withdrawRadioButton;
        private System.Windows.Forms.RadioButton depositeRadioButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button doItButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox selectAccountComboBox;
        private System.Windows.Forms.TextBox displayTextBox;
    }
}

