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

    
}