using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Student
    {
        public string Name { get; set; }
        private int avarage;
        public Student(string studentName, int studentAvarge)
        {
            Name = studentName;
            avarage = studentAvarge;
        }

        public int Avarage 
        {
            get
            {
                return avarage;
            }
            set
            {
                if (value > 0)
                {
                    if (value <= 100)
                    {
                        avarage = value;
                    }
                }
            }
        }

        public string LetterGrade
         {
            get
            {
                string letterGrade = string.Empty;
                if (avarage >= 90)
                {
                    letterGrade = "A";
                }
                else if (avarage >= 80)
                {
                    letterGrade = "B";
                }
                else if (avarage >= 70)
                {
                    letterGrade = "C";
                }
                else if (avarage >= 60)
                {
                    letterGrade =  "D";
                }
                else  
                {
                    letterGrade = "F";
                }
                return letterGrade;
            }

        }
    }
}
