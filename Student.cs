using System;

namespace Assignment2_1_1
{
    //Write a class: “Student” with private data members: StudentId ( int), StudentFname (string), StudentLname (string ), StudentGrade ( char ) and public properties for each data member.
    //Instantiate the class and assign data to properties. Display the data back on console.
    public class Student
    {
        private int StudentId;

        public int studentId
        {
            get
            {
                return StudentId;

            }
            set
            {
                StudentId = value;

            }
        }

        private string StudentFname;

        public string studentFname
        {
            get
            {
                return StudentFname;

            }
            set
            {
                StudentFname = value;

            }
        }

        private string StudentLname;

        public string studentLname
        {
            get
            {
                return StudentLname;

            }
            set
            {
                StudentLname = value;

            }
        }

        public Student(int StudentId, string StudentFname, string StudentLname)
        {
            this.StudentId = StudentId;
            this.StudentFname = StudentFname;
            this.StudentLname = StudentLname;
        }

	}
}
