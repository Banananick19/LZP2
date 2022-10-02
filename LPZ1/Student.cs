namespace LPZ1;

public class Student : Person, IDateAndCopy
{
    public Student(Person person, Education education, int groupNumber)
    {
        _person = person;
        _education = education;
        _groupNumber = groupNumber;
        _exams = new Exam[] { };
        _tests = new Test[]{};
    }

    public Student()
    {
        _person = new Person();
        _education = Education.Bachelor;
        _groupNumber = 0;
        _exams = new Exam[] { };
        _tests = new Test[]{};
    }
    
    
    public Person Person
    {
        get => _person;
        set => _person = value;
    }

    
    
    private Person _person;
    private Education _education;

    private int _groupNumber;
    private Exam[] _exams;
    private Test[] _tests;
    
    public System.Collections.Generic.IEnumerator<object> GetEnumerator()
    {
        foreach (var exam in _exams)
        {
            yield return exam;
        }

        foreach (var test in _tests)
        {
            yield return test;
        }
    }

    public System.Collections.Generic.IEnumerator<Exam> GetEnumerator(int grade)
    {
        foreach (var exam in _exams)
        {
            if (exam.Grade > grade) yield return exam;
        }
    }
    

    public Education Education
    {
        get => _education;
        set => _education = value;
    }

    public int GroupNumber
    {
        get => _groupNumber;
        set
        {
            if (value <= 100 || value > 599)
                throw new ArgumentOutOfRangeException("number > 100 and < 599");
            _groupNumber = value;
        }
    }

    public Exam[] Exams
    {
        get => _exams;
        set => _exams = value;
    }
    
    public Test[] Tests
    {
        get => _tests;
        set => _tests = value;
    }

    public double AverageGrade
    {
        get
        {
            if (_exams.Length > 0)
                return (double) _exams.Select(exam => exam.Grade).Aggregate((prod, next) => prod + next) /
                       _exams.Length;
            else return 0;
        }
    }

    public bool this[Education education] => education == _education;

    public void AddExam(Exam[] exams)
    {
        _exams = _exams.Concat(exams).ToArray();
    }
    
    public void AddTest(Test[] tests)
    {
        _tests = _tests.Concat(tests).ToArray();
    }

    public override string ToString()
    {
        return
            $"{_person} {_education} {_groupNumber} {AverageGrade} {_exams.Aggregate("", (prod, next) => prod + $"{next.ToString()} ")}";
    }
    
    public string ToShortString()
    {
        return
            $"{_person} {_education} {_groupNumber} {AverageGrade}";
    }
    
    public override bool Equals(object? obj)
    {
        if (obj is Student)
        {
            var other = (Student) obj;
            return Person == other.Person && Education == other.Education && GroupNumber == other.GroupNumber && Exams == other.Exams;
        }

        return false;
    }

    public static bool operator ==(Student student1, Student student2)
    {
        return student1.Equals(student2);
    }

    public static bool operator !=(Student student1, Student student2)
    {
        return !(student1 == student2);
    }

    public override int GetHashCode()
    {
        return _person.GetHashCode() + GroupNumber.GetHashCode() + Education.GetHashCode() + Exams.GetHashCode();
    }

    public object DeepCopy()
    {
        var student = new Student(_person, Education, GroupNumber);
        student.AddExam(_exams);
        student.AddTest(_tests);
        return student;
    }

    public DateTime Date { get; set; }
}