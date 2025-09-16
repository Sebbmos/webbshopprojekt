

namespace webbshopprojekt.ProductData
{
    public class Book: Product
    {
        public string Author;

        public override string ProductInformation()
        {
            return $"The book {Name} was written by {Author} and published by {Brand} price is {Price}";
        }

    }
}
