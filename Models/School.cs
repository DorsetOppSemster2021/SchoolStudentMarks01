using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStudentMarks01.Models
{
    // Create a class link
    // https://www.youtube.com/watch?v=Us2i7D-urgs&list=PLAC325451207E3105&index=19
    public class School
    {

        // Properties 
        // https://www.youtube.com/watch?v=iGR425gMKeA&list=PLAC325451207E3105&index=27
        public string Name { get; set; }

        public List<Student> listOfStudents { get; set; }

        public School(string _name)
        {
            Name = _name;
            //Create the list in the constructor - it will be empty to begin with
            //If we don't create it here, the program might blow up
            listOfStudents = new List<Student>();
        }

        public override string ToString()
        {
            return $"School is {Name}";
        }

        public void DisplayStudents()
        {
            // Process each item the in the list
            // https://www.youtube.com/watch?v=2zbFaDbADsQ&list=PLAC325451207E3105&index=15
            foreach (Student currentStudentInList in listOfStudents)
            {

                Console.WriteLine(currentStudentInList.ToString());

                currentStudentInList.DisplaySubjects();
            }

        }
    }
}
