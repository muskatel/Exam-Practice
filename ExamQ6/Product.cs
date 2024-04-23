namespace ExamQ6;

public class Product
{
    public int Id;
    public string Name;
    public double Price;
    public int Quantity;

    public Product(int id, string name, double price, int quantity)
    {
        Id = id;
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Price: {Price}, Name: {Name}, Quanity: {Quantity}";
    }
}