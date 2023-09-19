namespace Loan_Calculators
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMortgage = new Button();
            lblLoanAmount = new Label();
            txtLoanAmount = new TextBox();
            txtTermsInYears = new TextBox();
            txtInterestRate = new TextBox();
            txtDownPayment = new TextBox();
            lblDisplay = new Label();
            lblMonthlyPayment = new Label();
            lblTerms = new Label();
            lblInterestRate = new Label();
            lblDownPayment = new Label();
            btnAuto = new Button();
            SuspendLayout();
            // 
            // btnMortgage
            // 
            btnMortgage.Location = new Point(417, 289);
            btnMortgage.Name = "btnMortgage";
            btnMortgage.Size = new Size(112, 34);
            btnMortgage.TabIndex = 0;
            btnMortgage.Text = "Mortgage";
            btnMortgage.UseVisualStyleBackColor = true;
            btnMortgage.Click += btnMortgage_Click;
            // 
            // lblLoanAmount
            // 
            lblLoanAmount.AutoSize = true;
            lblLoanAmount.Location = new Point(206, 18);
            lblLoanAmount.Name = "lblLoanAmount";
            lblLoanAmount.Size = new Size(124, 25);
            lblLoanAmount.TabIndex = 1;
            lblLoanAmount.Text = "Loan Amount:";
            lblLoanAmount.Click += label1_Click;
            // 
            // txtLoanAmount
            // 
            txtLoanAmount.Location = new Point(417, 12);
            txtLoanAmount.Name = "txtLoanAmount";
            txtLoanAmount.Size = new Size(324, 31);
            txtLoanAmount.TabIndex = 2;
            // 
            // txtTermsInYears
            // 
            txtTermsInYears.Location = new Point(417, 221);
            txtTermsInYears.Name = "txtTermsInYears";
            txtTermsInYears.Size = new Size(324, 31);
            txtTermsInYears.TabIndex = 3;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(417, 149);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(324, 31);
            txtInterestRate.TabIndex = 4;
            // 
            // txtDownPayment
            // 
            txtDownPayment.Location = new Point(417, 82);
            txtDownPayment.Name = "txtDownPayment";
            txtDownPayment.Size = new Size(324, 31);
            txtDownPayment.TabIndex = 5;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Location = new Point(417, 368);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(0, 25);
            lblDisplay.TabIndex = 6;
            // 
            // lblMonthlyPayment
            // 
            lblMonthlyPayment.AutoSize = true;
            lblMonthlyPayment.Location = new Point(206, 368);
            lblMonthlyPayment.Name = "lblMonthlyPayment";
            lblMonthlyPayment.Size = new Size(155, 25);
            lblMonthlyPayment.TabIndex = 7;
            lblMonthlyPayment.Text = "Monthly Payment:";
            // 
            // lblTerms
            // 
            lblTerms.AutoSize = true;
            lblTerms.Location = new Point(206, 221);
            lblTerms.Name = "lblTerms";
            lblTerms.Size = new Size(126, 25);
            lblTerms.TabIndex = 8;
            lblTerms.Text = "Terms in Years:";
            // 
            // lblInterestRate
            // 
            lblInterestRate.AutoSize = true;
            lblInterestRate.Location = new Point(206, 149);
            lblInterestRate.Name = "lblInterestRate";
            lblInterestRate.Size = new Size(115, 25);
            lblInterestRate.TabIndex = 9;
            lblInterestRate.Text = "Interest Rate:";
            // 
            // lblDownPayment
            // 
            lblDownPayment.AutoSize = true;
            lblDownPayment.Location = new Point(206, 82);
            lblDownPayment.Name = "lblDownPayment";
            lblDownPayment.Size = new Size(136, 25);
            lblDownPayment.TabIndex = 10;
            lblDownPayment.Text = "Down Payment:";
            // 
            // btnAuto
            // 
            btnAuto.Location = new Point(629, 289);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(112, 34);
            btnAuto.TabIndex = 11;
            btnAuto.Text = "Auto";
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += btnAuto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAuto);
            Controls.Add(lblDownPayment);
            Controls.Add(lblInterestRate);
            Controls.Add(lblTerms);
            Controls.Add(lblMonthlyPayment);
            Controls.Add(lblDisplay);
            Controls.Add(txtDownPayment);
            Controls.Add(txtInterestRate);
            Controls.Add(txtTermsInYears);
            Controls.Add(txtLoanAmount);
            Controls.Add(lblLoanAmount);
            Controls.Add(btnMortgage);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMortgage;
        private Label lblLoanAmount;
        private TextBox txtLoanAmount;
        private TextBox txtTermsInYears;
        private TextBox txtInterestRate;
        private TextBox txtDownPayment;
        private Label lblDisplay;
        private Label lblMonthlyPayment;
        private Label lblTerms;
        private Label lblInterestRate;
        private Label lblDownPayment;
        private Button btnAuto;
    }
}