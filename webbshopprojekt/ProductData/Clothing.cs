

namespace webbshopprojekt.ProductData
{
    public class Clothing:Product
    {
        public string Size;
        public override string ProductInformation()
        {
            return $"The {Name} is of the brand {Brand} the size is {Size} price of article is {Price} ";
        }
    }
}
