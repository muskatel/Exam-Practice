using System.Globalization;

namespace ExamQ6;

public class ProductService
{
    public static List<Product> ReadProductsFromCsv(string csvFile)
    {
        List<Product> products = new List<Product>();

        StreamReader sr = new StreamReader(csvFile);
        int lineNo = 0;

        //skip header
        sr.ReadLine();
        lineNo++;


        //read data
        while (!sr.EndOfStream)
        {
            String line = sr.ReadLine();
            string[] values = line.Split(',');
            try
            {
                products.Add(
                    new Product(
                        int.Parse(values[0]),
                        values[1],
                        double.Parse(values[2], CultureInfo.InvariantCulture),
                        int.Parse(values[3])
                    ));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error on line {lineNo}: {ex.Message}");
            }

            lineNo++;
        }

        sr.Close();
        return products;
    }
}