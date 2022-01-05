using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsSample
{
    public class Student
    {

        public Student(string _Name, string _Department, int _Rdbms, int _Python, int _Oops)
        {
            Name = _Name;

            Department = _Department;

            Rdbms = _Rdbms;

            Python = _Python;

            Oops = _Oops;

        }


        public string Name;

        public string Department;

        public int Rdbms;

        public int Python;

        public int Oops;

        public string Result()
        {
            string result ="pass";

            if (Rdbms > 40 && Python > 40 && Oops > 40) 
            {
                result = "pass";
            }
            else
            {
                result = "fail";
            }


            return result;
        }
    }
}
