using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCampus
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Campus { get; set; }
        public string Degree { get; set; }


        public Student(string name, string surname, string campus, string degree)
        {
            Name = name;
            Surname = surname;
            Campus = campus;
            Degree = degree;
        }

        public override string ToString()
        {
            return $"Name: {Name}\tSurname: {Surname}\tCampus: {Campus}\tDegree: {Degree}";
        }
    }
}
