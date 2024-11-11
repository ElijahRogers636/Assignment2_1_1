namespace Assignment2_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(123, "Elijah", "Rogers", 'A');

            Console.WriteLine("ID: " + student1.studentId + "\nFirst Name: " + student1.studentFname + "\nLast Name: " + student1.studentLname + "\nGrade: " + student1.studentGrade);
        }
    }
}
