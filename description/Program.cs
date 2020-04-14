using System;

namespace description
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter students name:");
            string sName = Console.ReadLine();
            System.Console.Write("Enter students last name:");
            string sLastName = Console.ReadLine(); 
            System.Console.Write("Enter students grade:");
            int sGrade = int.Parse(Console.ReadLine());
            System.Console.Write("Enter students age:");
            int sAge = int.Parse(Console.ReadLine());
            Student nStudent = new Student(sName, sLastName, sGrade, sAge);
            nStudent.studentInfo();
        }
    }
    class Student 
    {
        public string Name {get; set;}
        public string LastName {get; set;}
        public int grade{get; set;}
        public int age {get; set;}
        public Student (string Name, string LastName, int grade, int age)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.grade = grade;
            this.age = age;
        }
        public Student (){}
        public void studentInfo()
        {
            System.Console.WriteLine($"Name: {Name}\nLastName: {LastName}\nStudent's grade: {grade}\nStudent's age: {age}");
        }
    }
}
