using System.Globalization;

namespace BillGenerator
{
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            billBox.Text = string.Empty;
            taxBox.Text = string.Empty;
            tipBox.Text = string.Empty;

            errMsg.Text = string.Empty;
            thanksMsg.Text = string.Empty;

            totalOutput.Text = "Total: ";
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            const decimal MAX_TOTAL_BEFORE_TOTAL_DOESNT_FIT_ON_SCREEN = 999_999_999_999_999_999.99M;

            decimal billData;
            decimal taxData;
            decimal tipData;

            string errorMessage;
            string errorReport = string.Empty;

            if (FormInputValidator.TryDollarInput(billBox.Text, out billData, out errorMessage) == false)
            {
                errorReport += "Error Parsing Bill Input. " + errorMessage + "\n";
            }

            if (FormInputValidator.TryPercentInput(taxBox.Text, out taxData, out errorMessage) == false)
            {
                errorReport += "Error Parsing Tax Input. " + errorMessage + "\n";
            }

            if (FormInputValidator.TryPercentInput(tipBox.Text, out tipData, out errorMessage) == false)
            {
                errorReport += "Error Parsing Tip Input. " + errorMessage + "\n";
            }

            if (errorReport == string.Empty)
            {
                errMsg.Text = string.Empty;
            }
            else
            {
                thanksMsg.Text = string.Empty;
                errMsg.Text = errorReport;
                return;
            }

            Bill bill = new(billData, taxData, tipData);

            bill.CalculateTotalBill();

            if(bill.total > MAX_TOTAL_BEFORE_TOTAL_DOESNT_FIT_ON_SCREEN)
            {
                totalOutput.Text = "Total: Too Expensive";
            }
            else
            {
              totalOutput.Text = "Total: " + bill.total.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            }
            

            if (bill.TipWasBig())
            {
                thanksMsg.Text = "THANK YOU!";
            }
            else
            {
                thanksMsg.Text = string.Empty;
            }

        }



        private void Theme_Click(object sender, EventArgs e)
        {
            if (themeBtn.Text == "LightMode")
            {
                themeBtn.ForeColor = Color.White;
                themeBtn.BackColor = Color.Black;
                themeBtn.Text = "DarkMode";
                ChangeTheme(Color.Black, Color.White);
            }
            else
            {
                themeBtn.ForeColor = Color.Black;
                themeBtn.BackColor = Color.White;
                themeBtn.Text = "LightMode";
                ChangeTheme(Color.White, Color.Black);
            }

        }
        private void ChangeTheme(Color backColor, Color foreColor)
        {
            this.BackColor = backColor;

            thanksMsg.ForeColor = foreColor;
            billLabel.ForeColor = foreColor;
            taxLabel.ForeColor = foreColor;
            tipLabel.ForeColor = foreColor;
            titleLabel.ForeColor = foreColor;
            panelLabel.ForeColor = foreColor;
            totalOutput.ForeColor = foreColor;
            calculateBtn.ForeColor = foreColor;
            clearBtn.ForeColor = foreColor;


        }
    }
}