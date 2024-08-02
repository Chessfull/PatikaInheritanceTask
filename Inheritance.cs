using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PatikaInheritanceTask
{
    //▼ Base Class ▼
    public class BasePerson
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void Greeting()
        {
            Console.WriteLine($"Name:{Name}\nSurname:{Surname}");
        }

    }

    // ▼ Student class inheritance from BasePerson with additional Student number prop ▼
    public class Student:BasePerson
    {
        public int StudentNumber { get; set; }
        // ▼ Ctor
        public Student(string name, string surname, int studentNumber)
        {
            this.Name = name;
            this.Surname = surname;
            this.StudentNumber = studentNumber;
        }
        // ▼ For displaying infos of student
        public void DisplayInfo()
        {
            //Using inheritance BasePerson method
            Greeting();

            Console.WriteLine($"Student Number:{StudentNumber}");
        }
    }

    // ▼ Teacher class inheritance from BasePerson with additional salary prop ▼
    public class Teacher:BasePerson
    {
        public double Salary { get; set; }

        public Teacher(string name, string surname, int salary)
        {
            this.Name=name;
            this.Surname = surname;
            this.Salary=salary;
        }
        // ▼ For displaying infos of teacher
        public void DisplayInfo()
        {
            //Using inheritance BasePerson method
            Greeting();

            Console.WriteLine($"Salary:{Salary}");
        }
    }

}
