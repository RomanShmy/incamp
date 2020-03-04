
using System.Collections.Generic;
using System.Text;
using System;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        private string name;
        private University university = new University();
        public Internship(string name)
        {
            this.name = name;     
        }

        public string GetStudents()
        {
            List<Student> students = university.getListOfStudents();
            StringBuilder names = new StringBuilder();
            double avg = AvgLevel(students);
            OrderBy orderBy = OrderBy.DESC;

            students.Sort((x, y) => (int)orderBy*x.GetLevelOfStudent().CompareTo(y.GetLevelOfStudent()));

            foreach (var student in students)
            {
                if (student.GetLevelOfStudent() >= avg)
                {
                    names.Append($"{student.getNameOfStudent()} : {student.GetLevelOfStudent()}").Append("\n");
                }
            }
            return names.ToString();
        }

        public double AvgLevel(List<Student> students){
            double avg;
            int sum = 0;

            foreach (var student in students)
            {
                sum += student.GetLevelOfStudent();
            }
            
            avg = sum * 1.0/ students.Count;

            return avg;
        }
    }

    enum OrderBy{
        ASC = 1,
        DESC = -1
    }
}
