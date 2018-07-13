using ConsoleApp3.utity;

namespace ConsoleApp3.product
{    
        public class Phone : Product
        {
            public override double computeTax()
            {
                return Price * 10 / 100;
            }
        }
    }
