using System;

namespace description
{
    class Program
    {
        static void Main(string[] args)
        {

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
            System.Console.WriteLine($"Name: {Name}\nLastName: {LastName}\nStudent's grade: {grade}\nStudent's age {age}");
        }
    }
}
