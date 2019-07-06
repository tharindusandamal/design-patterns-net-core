using StratergyPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace StratergyPattern.Concreate
{
    public class HighDiscountStrategy : IStrategy
    {
        public int GetFinalBill(int billAmount)
        {
            return (int)(billAmount - (billAmount * 0.5));
        }
    }
}
