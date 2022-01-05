using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace StaticConstructorsDemo
{
    class Student
    {
        //non-statcic data members  
        public string StudentName;
        public string Course;
        public void SetStudentDetails(string StuName, string Cou)
        {
            StudentName = StuName;
            Course = Cou;
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine(StudentName + " - " + Course);
        }

        //static data members  
        public static string CollegeName;
        public static string CollegeAddress;

        static Student()
        {
            CollegeName = "ABC College of Technology";

            CollegeAddress = "Hyderabad";

        }

        //static methods  
        public static void DisplayCollegeDetails()
        {
            Console.WriteLine(CollegeName);
            Console.WriteLine(CollegeAddress);
        }
    }
    class Program
    {
        static void deMain(string[] args)
        {
            //access static members  
            Student.DisplayCollegeDetails();

            //acess non-static members  
            Console.WriteLine();
            Student s1 = new Student();
            Student s2 = new Student();
            s1.SetStudentDetails("Sarath", "MCA");
            s1.SetStudentDetails("Syam", "MBA");
            s1.DisplayStudentDetails();
            s2.DisplayStudentDetails();
            //s1.DisplayCollegeDetails();
            Console.Read();
        }
    }
}