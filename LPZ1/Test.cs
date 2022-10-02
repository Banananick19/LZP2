namespace LPZ1;

public class Test
{
    public string SubjectName { get; set; }
    public bool Success { get; set; }

    public Test(string subjectName, bool success)
    {
        SubjectName = subjectName;
        Success = success;
    }

    public Test()
    {
        SubjectName = "--";
        Success = false;
    }

    public override string ToString()
    {
        return SubjectName + (Success ? "Сдан" : "Не сдан");
    }
}