using System;

namespace InternshipTest.Person
{
    public class Student : IComparable<Student>
    {
        private string name;
        private Knowledge knowledge; 
        public Student(string name)
        {
            this.name = name;
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            this.knowledge = knowledge;
        }

        public string getNameOfStudent()
        {
            return name;
        }

        public int GetLevelOfStudent()
        {
            return knowledge.getLevel();
        }

        public int CompareTo(Student other)
        {
            if (other == null)
                return 1;
            else
                return this.GetLevelOfStudent().CompareTo(other.GetLevelOfStudent());
        }
    }
}