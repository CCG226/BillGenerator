using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillGenerator
{
    internal class Bill
    {

        public Bill(decimal amount, decimal salesPerc, decimal tipPerc)
        {
            initialCost = amount;
            tipPercent = tipPerc;
            salesTaxPercent = salesPerc;
        }

        const int HUNDREDTH_PLACE = 2;

        private decimal initialCost { get; set; }
        private decimal tipPercent { get; set; }
        private decimal tipAmount { get; set; }
        private decimal salesTaxPercent { get; set; }
        public decimal total { get; set; }

        public bool TipWasBig()
        {
            const decimal BIG_TIP = 10;

            if (tipAmount > BIG_TIP)
            {
                return true;
            }

            return false;
        }
        public void CalculateTotalBill()
        {
            decimal salesTax = initialCost * salesTaxPercent;

            decimal applySalesTaxToBill = initialCost + salesTax;

            tipAmount = applySalesTaxToBill * tipPercent;

            decimal applyTipToBill = applySalesTaxToBill + tipAmount;

            total = Math.Round(applyTipToBill, HUNDREDTH_PLACE);
        }
    }
}
