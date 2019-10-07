namespace SnowBall
{
    partial class Form1
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
            this.NextDebtButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.FinishedButton = new System.Windows.Forms.Button();
            this.DebtMinimumPaymentLabel = new System.Windows.Forms.Label();
            this.MinimumPaymentTextBox = new System.Windows.Forms.TextBox();
            this.ExtraForDebtLabel = new System.Windows.Forms.Label();
            this.ExtraForDebtTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NextDebtButton
            // 
            this.NextDebtButton.Location = new System.Drawing.Point(311, 339);
            this.NextDebtButton.Name = "NextDebtButton";
            this.NextDebtButton.Size = new System.Drawing.Size(75, 23);
            this.NextDebtButton.TabIndex = 5;
            this.NextDebtButton.Text = "Next Debt";
            this.NextDebtButton.UseVisualStyleBackColor = true;
            this.NextDebtButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(311, 82);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(161, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(311, 121);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(161, 20);
            this.AmountTextBox.TabIndex = 2;
            this.AmountTextBox.TextChanged += new System.EventHandler(this.AmtBox_TextChanged);
            this.AmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmtBox_KeyPress);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(241, 85);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(64, 13);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Debt Name:";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(233, 128);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(72, 13);
            this.AmountLabel.TabIndex = 6;
            this.AmountLabel.Text = "Debt Amount:";
            // 
            // FinishedButton
            // 
            this.FinishedButton.Location = new System.Drawing.Point(396, 338);
            this.FinishedButton.Name = "FinishedButton";
            this.FinishedButton.Size = new System.Drawing.Size(91, 23);
            this.FinishedButton.TabIndex = 6;
            this.FinishedButton.Text = "Done";
            this.FinishedButton.UseVisualStyleBackColor = true;
            this.FinishedButton.Click += new System.EventHandler(this.FinishedButton_Click);
            // 
            // DebtMinimumPaymentLabel
            // 
            this.DebtMinimumPaymentLabel.AutoSize = true;
            this.DebtMinimumPaymentLabel.Location = new System.Drawing.Point(170, 163);
            this.DebtMinimumPaymentLabel.Name = "DebtMinimumPaymentLabel";
            this.DebtMinimumPaymentLabel.Size = new System.Drawing.Size(135, 13);
            this.DebtMinimumPaymentLabel.TabIndex = 7;
            this.DebtMinimumPaymentLabel.Text = "Minimum Monthly Payment:";
            // 
            // MinimumPaymentTextBox
            // 
            this.MinimumPaymentTextBox.Location = new System.Drawing.Point(311, 156);
            this.MinimumPaymentTextBox.Name = "MinimumPaymentTextBox";
            this.MinimumPaymentTextBox.Size = new System.Drawing.Size(161, 20);
            this.MinimumPaymentTextBox.TabIndex = 3;
            this.MinimumPaymentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MonthlyPayment_KeyPress);
            // 
            // ExtraForDebtLabel
            // 
            this.ExtraForDebtLabel.AutoSize = true;
            this.ExtraForDebtLabel.Location = new System.Drawing.Point(185, 207);
            this.ExtraForDebtLabel.Name = "ExtraForDebtLabel";
            this.ExtraForDebtLabel.Size = new System.Drawing.Size(120, 13);
            this.ExtraForDebtLabel.TabIndex = 9;
            this.ExtraForDebtLabel.Text = "Excess Money for Debt:";
            // 
            // ExtraForDebtTextBox
            // 
            this.ExtraForDebtTextBox.Location = new System.Drawing.Point(311, 200);
            this.ExtraForDebtTextBox.Name = "ExtraForDebtTextBox";
            this.ExtraForDebtTextBox.Size = new System.Drawing.Size(161, 20);
            this.ExtraForDebtTextBox.TabIndex = 4;
            this.ExtraForDebtTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExtraMoneyTxtBox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExtraForDebtTextBox);
            this.Controls.Add(this.ExtraForDebtLabel);
            this.Controls.Add(this.MinimumPaymentTextBox);
            this.Controls.Add(this.DebtMinimumPaymentLabel);
            this.Controls.Add(this.FinishedButton);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NextDebtButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextDebtButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Button FinishedButton;
        private System.Windows.Forms.Label DebtMinimumPaymentLabel;
        private System.Windows.Forms.TextBox MinimumPaymentTextBox;
        private System.Windows.Forms.Label ExtraForDebtLabel;
        private System.Windows.Forms.TextBox ExtraForDebtTextBox;
    }
}

