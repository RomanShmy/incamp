using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class University
    {
        private static List<Student> students = new List<Student>();
        private string name;
        

        public University() {}
        public University(string name)
        {
            this.name = name;
        }

        public void AddStudent(Student student, int level = 0)
        {
            student.SetKnowledge(new Knowledge(level));
            students.Add(student);
        }

        public List<Student> getListOfStudents(){
            return students;
        }
    }
}
