using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStudentMarks01.Models
{
    public class Student
    {
        public string Name { get; set; }

        public List<Subject> listOfSubjects = new List<Subject>();
        public Student(string _name)
        {
            Name = _name;

        }

        public override string ToString()
        {
            return $"\tStudent is {Name}";
        }

        public void DisplaySubjects()
        {

            foreach(Subject currentSubject in listOfSubjects)
            {

                Console.WriteLine($"\t\t{currentSubject.Name} : {currentSubject.Marks} :  {currentSubject.PassingScore} : {currentSubject.IsPassed()}");
            }

        }
    }
}
