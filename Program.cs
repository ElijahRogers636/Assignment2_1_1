namespace Assignment2_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(123, "Elijah", "Rogers", 'A');

            Console.WriteLine("ID: " + student1.StudentId + "\nFirst Name: " + student1.StudentFname + "\nLast Name: " + student1.StudentLname + "\nGrade: " + student1.StudentGrade);
        }
    }
}
