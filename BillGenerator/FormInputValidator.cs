using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillGenerator
{
    internal class FormInputValidator
    {
        public static bool TryDollarInput(string dollarInput, out decimal dollarAsDecimal, out string err)
        {
            const int HUNDREDTH_PLACE = 2;

            err = string.Empty;
            dollarAsDecimal = 0;
            if (dollarInput.Trim().Length == 0)
            {
                err = "Field Cannot Be Empty.";
                return false;
            }

            if (dollarInput[0] == '$')
            {
                dollarInput = dollarInput.Substring(1);
            }

            bool successfulParse = decimal.TryParse(dollarInput, out dollarAsDecimal);

            if (successfulParse is false)
            {
                err = "Input For Currency Must Be Numeric And Not To Large. Input Can Start With A '$' If You Want.";
                return false;
            }

            if (dollarAsDecimal < 0)
            {
                err = "Input For Currency Cannot Be Negative.";
                return false;
            }


            dollarAsDecimal = Math.Round(dollarAsDecimal, HUNDREDTH_PLACE);

            return true;
        }
        public static bool TryPercentInput(string percentInput, out decimal percentAsDecimal, out string err)
        {
            err = string.Empty;
            percentAsDecimal = 0;

            if (percentInput.Trim().Length == 0)
            {
                err = "Field Cannot Be Empty.";
                return false;
            }

            if (percentInput[percentInput.Length - 1] == '%')
            {
                percentInput = percentInput.Substring(0, percentInput.Length - 1);
            }

            bool successfulParse = decimal.TryParse(percentInput, out percentAsDecimal);

            if (successfulParse is false)
            {
                err = "Input For Percentage Must Be Numeric And Not To Large. Input Can Start With A '%' If You Want.";
                return false;
            }

            if (percentAsDecimal < 0)
            {
                err = "Error: Input For Percentage Cannot Be Negative.";
                return false;
            }

            percentAsDecimal = percentAsDecimal / 100M;

            return true;
        }

    }
}
