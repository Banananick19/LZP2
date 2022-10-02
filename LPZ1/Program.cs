// See https://aka.ms/new-console-template for more information

using LPZ1;

var person1 = new Person();
var person2 = new Person();
System.Console.WriteLine(person1.Equals(person2));
System.Console.WriteLine((object)person1 == (object)person2);
System.Console.WriteLine(person1.GetHashCode());
System.Console.WriteLine(person1.GetHashCode());
var student = new Student(person1, Education.Bachelor, 545);
student.AddExam(new Exam[] {new Exam()});
student.AddTest(new Test[] {new Test()});
Console.WriteLine(student.ToShortString());
Console.WriteLine(student.Person.ToString());
var student2 = (Student) student.DeepCopy();
student2.Education = Education.Specialist;
Console.WriteLine(student2.ToShortString);
try
{
    student2.GroupNumber = 1111;
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

var enu = student.GetEnumerator();
var flag = true;
while (flag)
{
    Console.WriteLine(enu.Current);
    flag = enu.MoveNext();
}

var enu2 = student.GetEnumerator(3);
flag = true;
while (flag)
{
    Console.WriteLine(enu.Current);
    flag = enu2.MoveNext();
}

