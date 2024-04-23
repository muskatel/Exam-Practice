namespace ExamQ6;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = ProductService.ReadProductsFromCsv("Products.csv");


        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }

        Console.WriteLine("Part 1");
        // Skriv alle produktene hvor antall produkter på lager (Quantity) er mindre enn 20.
        IEnumerable<Product> part1 = products
            .Where(p => p.Quantity < 20);

        foreach (Product product in part1)
        {
            Console.WriteLine(product);
        }

        Console.WriteLine("Part 2");
        // Craig's Preferred method
        // Skriv ut alle produkter hvor pris er mindre enn 20 
        foreach (Product product in products
                     .Where(p => p.Price < 20))
        {
            Console.WriteLine(product);
        }

        Console.WriteLine("Part 3");
        // Skriv ut alle produkter hvor produktnavn starter med bokstav ‘S’.
        foreach (Product product in products)
        {
            if (product.Name.StartsWith("S"))
            {
                Console.WriteLine(product);
            }
        }
    }
}