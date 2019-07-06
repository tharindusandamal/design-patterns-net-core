using StratergyPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace StratergyPattern.Concreate
{
    public class NoDiscountStrategy : IStrategy
    {
        public int GetFinalBill(int billAmount)
        {
            return billAmount;
        }
    }
}
