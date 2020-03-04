﻿using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("Alex");
            University university = new University("CH.U.I.");
            university.AddStudent(new Student("Andrew Kostenko"), 43);
            university.AddStudent(new Student("Julia Veselkina"), 63);
            university.AddStudent(new Student("Maria Perechrest"), 73);

            Internship internship = new Internship("Interlink");
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
        }
    }
}
