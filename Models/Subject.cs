using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStudentMarks01.Models
{
    public class Subject
    {
        public string Name { get; set; }

        public int PassingScore { get; set; }

        public int Marks { get; set; }
        public Subject(string _name, int _passingScore)
        {
            Name = _name;
            PassingScore = _passingScore;
            Marks = 0;
        }

        public Subject(string _name, int _passingScore, int _marks)
        {
            Name = _name;
            PassingScore = _passingScore;
            Marks = _marks;
        }

        public override string ToString()
        {
            return $"Subject is {Name} and passing score is {PassingScore}";
        }

        public bool IsPassed()
        {

            return Marks >= PassingScore;
        }
    }
}
