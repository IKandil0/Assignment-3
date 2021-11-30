using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
    class Subject
    {
        public int subjectId { get; set; }
        public string subjectName { get; set; }
        public int studentId { get; set; }
        public double degree { get; set; }
    }

    class Student
    {
        public int studentId { get; set; }
        public string studentName { get; set; }
        public List<Subject> Sub { get; set; }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            List<Student> studentlist = new List<Student>();
            for (int i = 1; i <= 12; i++)
            {
                Student S = new Student();
               
                S.studentId = i;
                S.studentName = "student " + i;
                S.Sub = new List<Subject>();
                int id = 1;
                for (int j = 1; j <= 5; j++)
                {
                    Subject subject = new Subject();
                    subject.studentId = i;
                    subject.subjectId = id++;
                    subject.subjectName = "subject " + i + " " + j;
                    Console.WriteLine("please enter the degree of subject " + i + " " + j);
                    subject.degree = double.Parse(Console.ReadLine());
                    S.Sub.Add(subject);
                }
                studentlist.Add(S);
            }

            foreach (var item in studentlist)
                Console.WriteLine(item.studentName + "=> " + item.Sub.Sum(x => x.degree) * 100 / 500 + " % ");
            Console.ReadKey();

        }
    }
}