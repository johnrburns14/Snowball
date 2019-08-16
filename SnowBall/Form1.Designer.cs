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
            this.GoNextButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AmtBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AmtLabel = new System.Windows.Forms.Label();
            this.FinishedButton = new System.Windows.Forms.Button();
            this.DebtMinPaymentLabel = new System.Windows.Forms.Label();
            this.MonthlyPayment = new System.Windows.Forms.TextBox();
            this.ExtraDebtMoney = new System.Windows.Forms.Label();
            this.ExtraMoneyTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GoNextButton
            // 
            this.GoNextButton.Location = new System.Drawing.Point(311, 339);
            this.GoNextButton.Name = "GoNextButton";
            this.GoNextButton.Size = new System.Drawing.Size(75, 23);
            this.GoNextButton.TabIndex = 5;
            this.GoNextButton.Text = "Next Debt";
            this.GoNextButton.UseVisualStyleBackColor = true;
            this.GoNextButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(311, 82);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(161, 20);
            this.NameBox.TabIndex = 1;
            // 
            // AmtBox
            // 
            this.AmtBox.Location = new System.Drawing.Point(311, 121);
            this.AmtBox.Name = "AmtBox";
            this.AmtBox.Size = new System.Drawing.Size(161, 20);
            this.AmtBox.TabIndex = 2;
            this.AmtBox.TextChanged += new System.EventHandler(this.AmtBox_TextChanged);
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
            // AmtLabel
            // 
            this.AmtLabel.AutoSize = true;
            this.AmtLabel.Location = new System.Drawing.Point(233, 128);
            this.AmtLabel.Name = "AmtLabel";
            this.AmtLabel.Size = new System.Drawing.Size(72, 13);
            this.AmtLabel.TabIndex = 6;
            this.AmtLabel.Text = "Debt Amount:";
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
            // DebtMinPaymentLabel
            // 
            this.DebtMinPaymentLabel.AutoSize = true;
            this.DebtMinPaymentLabel.Location = new System.Drawing.Point(170, 163);
            this.DebtMinPaymentLabel.Name = "DebtMinPaymentLabel";
            this.DebtMinPaymentLabel.Size = new System.Drawing.Size(135, 13);
            this.DebtMinPaymentLabel.TabIndex = 7;
            this.DebtMinPaymentLabel.Text = "Minimum Monthly Payment:";
            // 
            // MonthlyPayment
            // 
            this.MonthlyPayment.Location = new System.Drawing.Point(311, 156);
            this.MonthlyPayment.Name = "MonthlyPayment";
            this.MonthlyPayment.Size = new System.Drawing.Size(161, 20);
            this.MonthlyPayment.TabIndex = 3;
            // 
            // ExtraDebtMoney
            // 
            this.ExtraDebtMoney.AutoSize = true;
            this.ExtraDebtMoney.Location = new System.Drawing.Point(185, 207);
            this.ExtraDebtMoney.Name = "ExtraDebtMoney";
            this.ExtraDebtMoney.Size = new System.Drawing.Size(120, 13);
            this.ExtraDebtMoney.TabIndex = 9;
            this.ExtraDebtMoney.Text = "Excess Money for Debt:";
            // 
            // ExtraMoneyTxtBox
            // 
            this.ExtraMoneyTxtBox.Location = new System.Drawing.Point(311, 200);
            this.ExtraMoneyTxtBox.Name = "ExtraMoneyTxtBox";
            this.ExtraMoneyTxtBox.Size = new System.Drawing.Size(161, 20);
            this.ExtraMoneyTxtBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExtraMoneyTxtBox);
            this.Controls.Add(this.ExtraDebtMoney);
            this.Controls.Add(this.MonthlyPayment);
            this.Controls.Add(this.DebtMinPaymentLabel);
            this.Controls.Add(this.FinishedButton);
            this.Controls.Add(this.AmtLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AmtBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.GoNextButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoNextButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox AmtBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AmtLabel;
        private System.Windows.Forms.Button FinishedButton;
        private System.Windows.Forms.Label DebtMinPaymentLabel;
        private System.Windows.Forms.TextBox MonthlyPayment;
        private System.Windows.Forms.Label ExtraDebtMoney;
        private System.Windows.Forms.TextBox ExtraMoneyTxtBox;
    }
}

