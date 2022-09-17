namespace LPZ1;

public class MainClass
{
    static void Main(string[] args)
    {
        var student = new Student();
        
        System.Console.WriteLine(student.ToShortString());
        
        System.Console.WriteLine($"{Education.Bachelor} {student[Education.Bachelor]}");
        System.Console.WriteLine($"{Education.Specialist} {student[Education.Specialist]}");
        System.Console.WriteLine($"{Education.SecondEducation} {student[Education.SecondEducation]}");

        student.Education = Education.Specialist;
        student.Person = new Person("123", "123", DateTime.Now);
        student.GroupNumber = 123;
        
        System.Console.WriteLine(student.ToString());
        
        student.AddExam(new [] {new Exam("123", 123, DateTime.Now)});
        
        System.Console.WriteLine(student.ToString());

        System.Console.WriteLine("Введите кол-во строк");
        var nrow =  Int32.Parse(System.Console.ReadLine());
        
        System.Console.WriteLine("Введите кол-во столбцов");
        var ncolumn = Int32.Parse(System.Console.ReadLine());

        var array1 = new Exam[nrow*ncolumn];
        var array2 = new Exam[nrow, ncolumn];
        var arrayStairs = new Exam[nrow][];

        for (int i = 0; i < nrow * ncolumn; i++)
        {
            array1[i] = new Exam();
        }

        for (int i = 0; i < nrow; i++)
        {
            for (int k = 0; k < ncolumn; k++)
            {
                array2[i, k] = new Exam();
                arrayStairs[i][k] = new Exam();
            }
        }

        var start1 = Environment.TickCount;
        var count1 = 0;
        foreach (var exam in array1)
        {
            exam.Grade = 5;
            count1++;
        }

        var end1 = Environment.TickCount - start1;
        
        var start2 = Environment.TickCount;
        var count2 = 0;
        foreach (var exam in array2)
        {
            exam.Grade = 5;
            count2++;
        }

        var end2 = Environment.TickCount - start2;
        
        var start3 = Environment.TickCount;
        var count3 = 0;
        foreach (var exams in arrayStairs)
        {
            foreach (var exam in exams)
            {
                exam.Grade = 5;
                count3++;
            }
        }

        var end3 = Environment.TickCount - start3;

        System.Console.WriteLine($"{count1} {count2} {count3}");



    }
}