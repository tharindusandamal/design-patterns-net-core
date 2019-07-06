using StratergyPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace StratergyPattern
{
    public class ShopingMall
    {
        public string CustomerName { get; set; }
        public int BillAmount { get; set; }

        public ShopingMall()
        {

        }

        public IStrategy CurruntStrategy;
        public ShopingMall(IStrategy NewStrategy)
        {
            CurruntStrategy = NewStrategy;
        }

        public int GetFinalBill()
        {
            return CurruntStrategy.GetFinalBill(BillAmount);
        }
    }
}
