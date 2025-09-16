

namespace webbshopprojekt.ProductData
{
    public class Product
    {
        //class variabler
        public static double GlobalDiscount = 0.0;
        public static int NextId = 1;
        public static int TotalCount = 0;          //visar totala artiklar i listan Case 3



        //objekt variabler
        public int Id;
        public string Name;
        public string Brand;
        public double Price;


        //constructor

        public Product()
        {
            Id = NextId;
            NextId++;
            TotalCount++;
        }

        public virtual string ProductInformation()
        {
            return $" {Name} {Brand} {Price}";
        }

        public string ProductDetails()
        {
            return $"{Id} {Name} {Price}";
        }


        // metod för Case 5 Rabatter.
        public static void SetGlobalDiscountPercent(double percent)
        {
            GlobalDiscount = percent / 100;
        }

        public virtual double FinalPrice()
        {
            double discountFactor = 1 - GlobalDiscount;
            return Price = discountFactor;
        }
    }
}
