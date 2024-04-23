namespace ExamQ3;

class Program
{
    static void Main(string[] args)
    {
        Author JN = new Author(1960, "Jo", "Nesbø");
        Author TE = new Author(1959, "Tom", "Egeland");

        Book Snømannen = new Book(JN, 2007, "Snømannen");
        Book SirkelensEnde = new Book(TE, 2001, "Sirkelens ende");
        
        Console.WriteLine(Snømannen.GetBookInfo());
        Console.WriteLine(SirkelensEnde.GetBookInfo());
    }
}