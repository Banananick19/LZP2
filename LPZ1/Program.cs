// See https://aka.ms/new-console-template for more information

using LPZ1;

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

System.Console.WriteLine("Введите кол-во строк и столбцов. (Разделители: пробел, запятая)");
var str = System.Console.ReadLine();

var nrow = Int32.Parse(str.Split(new[] {' ', ','})[0]);
var ncolumn = Int32.Parse(str.Split(new[] {' ', ','})[1]);

var array1 = new Exam[nrow*ncolumn];
var array2 = new Exam[nrow, ncolumn];
var arrayStairs = new Exam[nrow][];


for (int i = 0; i < nrow * ncolumn; i++)
{
    array1[i] = new Exam();
}

for (int i = 0; i < nrow; i++)
{
    arrayStairs[i] = new Exam[ncolumn];
    for (int k = 0; k < ncolumn; k++)
    {
        array2[i, k] = new Exam();
        arrayStairs[i][k] = new Exam();
    }
}

var start1 = Environment.TickCount;
foreach (var exam in array1)
{
    exam.Grade = 5;
}

var end1 = Environment.TickCount - start1;

var start2 = Environment.TickCount;
foreach (var exam in array2)
{
    exam.Grade = 5;
}

var end2 = Environment.TickCount - start2;

var start3 = Environment.TickCount;
foreach (var exams in arrayStairs)
{
    foreach (var exam in exams)
    {
        exam.Grade = 5;
    }
}

var end3 = Environment.TickCount - start3;

System.Console.WriteLine($"array1: {end1} ; array2: {end2} ; arrayStairs: {end3}");
