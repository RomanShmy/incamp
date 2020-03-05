using System.Collections.Generic;
using System.Linq;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship : Institution
    {
        private string _name;
        
        public Internship(string name)
        {
            _name = name;
        }
        
        public string GetStudents()
        {    
            var university = new University();
            var students = university.Students;
            return string.Join("/n", students);
        }

        
    }
}
