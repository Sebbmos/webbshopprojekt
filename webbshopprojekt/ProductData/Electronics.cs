
namespace webbshopprojekt.ProductData
{
    public class Electronics:Product
    {
        public int WarrantyYears;

        public override string ProductInformation()
        {
            return $"The electronic {Name} is of the brand {Brand} and has {WarrantyYears} years of warranty. price is {Price}  ";
        }

    }
}
