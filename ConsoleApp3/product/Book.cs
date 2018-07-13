using System;
using ConsoleApp3.utity;

namespace ConsoleApp3.product
{
    public class Book : Product
    {
        public override double computeTax()
        {
            return Price * 5 / 100;
        }
    }
}