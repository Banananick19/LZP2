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

    public override bool Equals(object? obj)
    {
        if (obj is Person)
        {
            var other = (Person) obj;
            return _name == other.Name && _surname == other.Surname && _birthday == other.BirthDay;
        }

        return false;
    }

    public static bool operator ==(Person person1, Person person2)
    {
        return person1.Equals(person2);
    }

    public static bool operator !=(Person person1, Person person2)
    {
        return !(person1 == person2);
    }

    public override int GetHashCode()
    {
        return _birthday.GetHashCode() + _name.GetHashCode() + _surname.GetHashCode();
    }

    public object DeepCopy()
    {
        return new Person(Name, Surname, BirthDay);
    }
}