namespace ExamQ3;

public class Author
{
    private int _birthYear;
    private string _firstName;
    private string _lastName;

    public int BirthYear
    {
        get => _birthYear;
    }

    public string FirstName
    {
        get => _firstName;
    }

    public string LastName
    {
        get => _lastName;
    }

    public Author(
        int birthYear, 
        string firstName, 
        string lastName)
    {
        _birthYear = birthYear;
        _firstName = firstName;
        _lastName = lastName;
    }

    public string GetFullName()
    {
        return _firstName + " " + _lastName;
    }

    public override string ToString()
    {
        return GetFullName() + " (" + _birthYear + ")";
    }
}