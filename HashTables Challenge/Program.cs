using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            Hashtable studentsTable = new Hashtable();
            foreach (var student in students)
            {
                if (studentsTable.ContainsKey(student.Id))
                {
                    Console.WriteLine("Sorry, a student with the same Id already exists");
                }
                else
                {
                    studentsTable.Add(student.Id, student);
                    Console.WriteLine("ID: {0}", student.Id);
                    Console.WriteLine("Name: {0}", student.Name);
                    Console.WriteLine("GPA: {0}", student.GPA);
                }
            }

            Console.ReadLine();
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
