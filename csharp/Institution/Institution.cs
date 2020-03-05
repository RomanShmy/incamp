using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution
{
    public abstract class Institution
    {
        public List<Student> Students { get; protected set; } = new List<Student>();
    }
}