using InternshipTest.Person;
using System.Collections.Generic;
using System.Linq;
using InternshipTest.Institution.InterLink;

namespace InternshipTest.Institution
{
    public class University : Institution
    {
        private readonly List<Student> _students = new List<Student>();
        private string name;
        
        public University() {}
        public University(string name)
        {
            this.name = name;
        }

        public void AddStudent(Student student, int level = 0)
        {
            student.SetKnowledge(new Knowledge(level));
            _students.Add(student);
            Students = GoToIntership(_students);
        }

        public List<Student> GoToIntership(List<Student> students,OrderBy orderBy = OrderBy.DESC)
        {
            List<Student> goodStudents = new List<Student>();
            var avg = AvgLevel(students);
            
            students.Sort((x, y) => (int)orderBy*x.GetLevelOfStudent().CompareTo(y.GetLevelOfStudent()));
            
            foreach (var student in students)
            {
                if (student.GetLevelOfStudent() >= avg)
                {
                    goodStudents.Add(student);
                }
            }

            var internship = new University {};

            return goodStudents;
        }

        private static double AvgLevel(List<Student> students){
            var sum = students.Sum(student => student.GetLevelOfStudent());

            var avg = sum * 1.0/ students.Count;

            return avg;
        }

    }

    public enum OrderBy{
        ASC = 1,
        DESC = -1
    }
}
