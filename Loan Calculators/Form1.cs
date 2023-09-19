namespace Loan_Calculators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMortgage_Click(object sender, EventArgs e)
        {

            //Declaration of variables
            double loanAmount = 0.0;
            double downPayment = 0.0;
            double interestRate = 0.0;
            double monthlyPayment = 0.0;
            int terms = 0;

            //Validation
            if (!String.IsNullOrEmpty(txtLoanAmount.Text)) { loanAmount = Convert.ToDouble(txtLoanAmount.Text); }
            if (!String.IsNullOrEmpty(txtDownPayment.Text)) { downPayment = Convert.ToDouble(txtDownPayment.Text); }
            if (!String.IsNullOrEmpty(txtInterestRate.Text)) { interestRate = Convert.ToDouble(txtInterestRate.Text); }
            if (!String.IsNullOrEmpty(txtTermsInYears.Text)) { terms = Convert.ToInt32(txtTermsInYears.Text); }

            //Auto Payment
            //Formula: Payment= (Loan Amount - Down Paument) * (1+ Interest Rate/12)^(Terms*12)
            int termsinMonths = terms * 12;
            monthlyPayment = (loanAmount - downPayment) * (Math.Pow((1 + interestRate / 12), termsinMonths) * interestRate) / (12 * (Math.Pow((1 + interestRate / 12), termsinMonths) - 1));
            monthlyPayment = Math.Round(monthlyPayment, 2);

            //Display
            lblDisplay.Text = String.Format("R {0}", monthlyPayment.ToString());

        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            //Declaration of variables
            double loanAmount = 0.0;
            double downPayment = 0.0;
            double interestRate = 0.0;
            double monthlyPayment = 0.0;
            int terms = 0;

            //Validation
            if (!String.IsNullOrEmpty(txtLoanAmount.Text)) { loanAmount= Convert.ToDouble(txtLoanAmount.Text);}
            if (!String.IsNullOrEmpty(txtDownPayment.Text)) { downPayment=Convert.ToDouble(txtDownPayment.Text);}
            if (!String.IsNullOrEmpty(txtInterestRate.Text)) { interestRate=Convert.ToDouble(txtInterestRate.Text);}
            if (!String.IsNullOrEmpty(txtTermsInYears.Text)) { terms=Convert.ToInt32(txtTermsInYears.Text);}

            //Auto Payment
            //Formula: Payment= (Loan Amount*Interest Rate)/(1-(1+Interest Rate)^Terms
            int termsinMonths = terms * 12;
            interestRate/=12;
            monthlyPayment = (loanAmount * interestRate) / (1 - (Math.Pow((1 + interestRate), termsinMonths)));
            monthlyPayment=Math.Round(monthlyPayment, 2);

            //Display
            lblDisplay.Text=String.Format("R {0}",monthlyPayment.ToString());
           
        }
    }
}