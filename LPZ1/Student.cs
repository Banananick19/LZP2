namespace LPZ1;

public class Student
{
    public Student(Person person, Education education, int groupNumber)
    {
        _person = person;
        _education = education;
        _groupNumber = groupNumber;
    }

    public Student()
    {
        _person = new Person();
        _education = Education.Bachelor;
        _groupNumber = 0;
        _exams = new Exam[] { };
    }
    
    
    private Person _person;
    private Education _education;
    private int _groupNumber;
    private Exam[] _exams;

    public Person Person
    {
        get => _person;
        set => _person = value;
    }

    public Education Education
    {
        get => _education;
        set => _education = value;
    }

    public int GroupNumber
    {
        get => _groupNumber;
        set => _groupNumber = value;
    }

    public Exam[] Exams
    {
        get => _exams;
        set => _exams = value;
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
}