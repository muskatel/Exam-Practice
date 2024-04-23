namespace ExamQ3;

public class Book
{
    private Author _author;
    private int _publicatinYear;
    private string _title;

    public Author Author
    {
        get => _author;
    }

    public int PublicatinYear
    {
        get => _publicatinYear;
    }

    public string Title
    {
        get => _title;
    }

    public Book(Author author, int publicatinYear, string title)
    {
        _author = author;
        _publicatinYear = publicatinYear;
        _title = title;
    }

    public string GetBookInfo()
    {
        return $"{_title} av {_author.GetFullName()}, publisert i {_publicatinYear}";
    }

    public override string ToString()
    {
        return GetBookInfo();
    }
}