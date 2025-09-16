using webbshopprojekt.ProductData;

namespace webbshopprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> inventory = new List<Product>()
            {
                new Book {Name = "potatobook", Brand = "Potatoes united", Author = "Potato", Price = 200, Id = 1 }
            };


            bool running = true;
            while (running)
            {
                Console.WriteLine("===== Tamims webshop admin panel =====");
                Console.WriteLine("[1]. Lägg till produkt");
                Console.WriteLine("[2]. Lista produkter");
                Console.WriteLine("[3]. Antal produkter");
                Console.WriteLine("[4]. Totalt värde");
                Console.WriteLine("[5]. Ändra global rabatt");
                Console.WriteLine("[6] Avsluta");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProductMenu(inventory);
                        break;
                    case 2:
                        Listproducts(inventory);
                        break;
                    case 3:
                        Console.WriteLine(Product.TotalCount);
                        break;
                    case 4:
                        Console.WriteLine($"The total value at your inventory is {CalculateTotalValue(inventory)}");
                        break;
                    case 5:
                        ChangeGlobalDiscount();
                        Console.WriteLine("The discount is now added to all the products");
                        break;
                    case 6:
                        Console.WriteLine("6");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            //Lista för case 1
            static void AddProductMenu(List<Product> inventory)
            {
                Console.WriteLine("[1]. Book");
                Console.WriteLine("[2]. Electronics");
                Console.WriteLine("[3]. Clothing");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Book b = new Book();
                        FillCommonFields(b);
                        Console.Write("Author: ");
                        b.Author = Console.ReadLine();
                        inventory.Add(b);

                        break;
                    case 2:
                        Electronics e = new Electronics();
                        FillCommonFields(e);
                        Console.Write("WarrantyYears: ");
                        e.WarrantyYears =int.Parse(Console.ReadLine());
                        inventory.Add(e);

                        break;
                    case 3:
                        Clothing c = new Clothing();
                        FillCommonFields(c);
                        Console.Write("Size: ");
                        c.Size = Console.ReadLine();
                        inventory.Add(c);

                        break;
                    default:
                        break;
                }
            }
            //metod för att lägga till produkt
            static void FillCommonFields(Product p)
            {
                Console.Write("Name: ");
                p.Name = Console.ReadLine();
                Console.Write("Brand: ");
                p.Brand = Console.ReadLine();
                Console.Write("Price: ");
                p.Price = double.Parse(Console.ReadLine());

            }
            // metod för lista av produkter Case 2

            static void Listproducts(List<Product> products)
            {
                foreach(Product p in products)
                {
                    Console.WriteLine(p.ProductDetails());
                }

            }

            static double CalculateTotalValue(List<Product> products)
            {
                double sum = 0;
                foreach (Product p in products)
                {
                   sum += p.Price;

                }
                return sum;
            }
            static void ChangeGlobalDiscount()
            {
                Console.Write("New discount in %");
                double percent = double.Parse(Console.ReadLine());
                Product.SetGlobalDiscountPercent(percent);
            }
        }
    }


}
