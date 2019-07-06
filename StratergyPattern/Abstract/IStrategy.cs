using System;
using System.Collections.Generic;
using System.Text;

namespace StratergyPattern.Abstract
{
    public interface IStrategy
    {
        int GetFinalBill(int billAmount);
    }
}
