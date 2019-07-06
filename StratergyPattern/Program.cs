using StratergyPattern.Concreate;
using System;

namespace StratergyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // low discount strategy
            ShopingMall shopingMall1 = new ShopingMall
            {
                CustomerName = "Tharindu",
                BillAmount = 1000,
                CurruntStrategy = new LowDiscountStrategy()
            };
            Console.WriteLine($"Final bill: {shopingMall1.GetFinalBill()}");

            // high discount strategy
            ShopingMall shopingMall2 = new ShopingMall
            {
                CustomerName = "Tharindu",
                BillAmount = 1000,
                CurruntStrategy = new HighDiscountStrategy()
            };
            Console.WriteLine($"Final bill: {shopingMall2.GetFinalBill()}");

            // no discount strategy
            ShopingMall shopingMall3 = new ShopingMall
            {
                CustomerName = "Tharindu",
                BillAmount = 1000,
                CurruntStrategy = new NoDiscountStrategy()
            };
            Console.WriteLine($"Final bill: {shopingMall3.GetFinalBill()}");

            Console.ReadLine();
        }
    }
}
