using HM.CustomMyListClass.Models;
using System;
using System.Collections.Generic;

namespace HM.CustomMyListClass
{
    public class Program
    {
        public static void Main(string[] args)
        {

            MyList<Student> mylist = new MyList<Student>();
            Student student0 = new Student("Vusal", "Aliyev");
            Student student1 = new Student("Namiq", "Zeynebov");
            Student student2 = new Student("Resul", "Valiyev");

            mylist.Add(student0);
            mylist.Add(student1);
            mylist.Add(student2);

            mylist.GetAll();


            //Student student0 = new Student
            //{
            //    Name = "Namiq"
            //};
            //Student student1 = new Student
            //{
            //    Name = "Ramiz"
            //};
            //Student student2 = new Student
            //{
            //    Name = "Tural"
            //};
            //Student student3 = new Student
            //{
            //    Name = "Nergiz"
            //};
            //Student student4 = new Student
            //{
            //    Name = "Leyla"
            //};
            //University university = new University();
            //university[0] = student0;
            //university[1] = student1;
            //university[2] = student2;
            //university[3] = student3;
            //university[4] = student4;

            //Console.WriteLine($"{university[0]} and {university[1]}"); ;



        }

    }
}