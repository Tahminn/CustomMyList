using System;
using System.Collections.Generic;
using System.Text;

namespace HM.CustomMyListClass.Models
{
    public class Student
    {
        //public string Name { get; set; }
        //public override string ToString()
        //{ 
        //    return Name;
        //}

        public string Name { get; set; }
        public string Surname { get; set; }

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

    }
}
