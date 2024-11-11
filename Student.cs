using System;

namespace Assignment2_1_1
{
    //Write a class: “Student” with private data members: StudentId ( int), StudentFname (string), StudentLname (string ), StudentGrade ( char ) and public properties for each data member.
    //Instantiate the class and assign data to properties. Display the data back on console.
    public class Student
    {
        private int studentId;

        public int StudentId
        {
            get
            {
                return studentId;

            }
            set
            {
                studentId = value;

            }
        }

        private string studentFname;

        public string StudentFname
        {
            get
            {
                return studentFname;

            }
            set
            {
                studentFname = value;

            }
        }

        private string studentLname;

        public string StudentLname
        {
            get
            {
                return studentLname;

            }
            set
            {
                studentLname = value;

            }
        }

        private char studentGrade;

        public char StudentGrade
        {
            get
            {
                return studentGrade;

            }
            set
            {
                studentGrade = value;

            }
        }
        public Student(int StudentId, string StudentFname, string StudentLname, char StudentGrade)
        {
            this.studentId = StudentId;
            this.studentFname = StudentFname;
            this.studentLname = StudentLname;
            this.studentGrade = StudentGrade;
        }

	}
}
