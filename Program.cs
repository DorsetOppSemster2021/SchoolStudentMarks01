
using SchoolStudentMarks01.Models;
using System;

namespace SchoolStudentMarks01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello School!");

            School school1 = new School("Dorset College");
            Console.WriteLine(school1.ToString());

            Student student1 = new Student("Bruce Wayne");
            Student student2 = new Student("Peter Parker");

            Subject subject1 = new Subject("English",75, 60);
            Subject subject2 = new Subject("Geography",75, 86);
            Subject subject3 = new Subject("English",75, 75);

            student1.listOfSubjects.Add(subject1);
            student1.listOfSubjects.Add(subject2);

            student2.listOfSubjects.Add(subject3);



            school1.listOfStudents.Add(student1);
            school1.listOfStudents.Add(student2);

            school1.DisplayStudents();

        }
    }
}
