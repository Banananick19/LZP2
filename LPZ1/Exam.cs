namespace LPZ1;

public class Exam
{
       
    public Exam(string subjectName, int grade, DateTime date)
    {
        SubjectName = subjectName;
        Grade = grade;
        Date = date;
    }

    public Exam()
    {
        SubjectName = "---";
        Grade = 0;
        Date = DateTime.MinValue;
    }
    
    public string SubjectName { get; set; }
    public int Grade { get; set; }
    public DateTime Date { get; set; }
 

    public override string ToString()
    {
        return $"{SubjectName} {Date} {Grade}";
    }
    
    
    public override bool Equals(object? obj)
    {
        if (obj is Exam)
        {
            var other = (Exam) obj;
            return SubjectName == other.SubjectName && Grade == other.Grade && Date == other.Date;
        }

        return false;
    }

    public static bool operator ==(Exam exam1, Exam exam2)
    {
        return exam1.Equals(exam2);
    }

    public static bool operator !=(Exam exam1, Exam exam2)
    {
        return !(exam1 == exam2);
    }

    public override int GetHashCode()
    {
        return SubjectName.GetHashCode() + Grade.GetHashCode() + Date.GetHashCode();
    }

    public object DeepCopy()
    {
        return new Exam(SubjectName, Grade, Date);
    }
    
}