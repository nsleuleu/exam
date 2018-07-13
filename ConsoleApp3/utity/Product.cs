namespace ConsoleApp3.utity
{
    public abstract class Product
    {
        private int _id;
        private string _name;
        private double _price;

        protected Product()
        {
        }

        protected Product(int id, string name, double price)
        {
            _id = id;
            _name = name;
            _price = price;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public double Price
        {
            get => _price;
            set => _price = value;
        }

        public abstract double computeTax();

    }
}