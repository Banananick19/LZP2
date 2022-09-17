namespace LPZ1;

public class Person
{
    public Person(string name, string surname, DateTime birthday)
    {
        _name = name;
        _surname = surname;
        _birthday = birthday;
    }

    public Person()
    {
        _name = "---";
        _surname = "---";
        _birthday = DateTime.MinValue;
    }

    
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Surname
    {
        get => _surname;
        set => _surname = value;
    }

    public DateTime BirthDay
    {
        get => _birthday;
        set => _birthday = value;
    }
    
    
    private string _name;
    private string _surname;
    private DateTime _birthday;

   
    public override string ToString()
    {
        return $"{_surname} {_name} {_birthday}";
    }

    public string ToShortString()
    {
        return $"{_surname} {_name}";
    }
}