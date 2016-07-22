using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DQS.Controls.CommonCode
{
    public class TotalPriceChangedArgs
    {
        private double m_TotalPrice;

        private double m_Percent;
        public TotalPriceChangedArgs(double totalPrice)
        {
            this.m_TotalPrice = totalPrice;
        }

        public double TotalPrice
        {
            get
            {
                return this.m_TotalPrice;
            }
        }
    }
}
