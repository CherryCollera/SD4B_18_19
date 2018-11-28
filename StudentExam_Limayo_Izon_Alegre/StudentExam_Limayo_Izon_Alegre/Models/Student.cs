using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExam_Limayo_Izon_Alegre.Models
{
    class Student : Person
    {
        public int ID { get; set; }
        public string StudentNumber { get; set; }
        public double FinalGrade { get; set; }
        public List<double> myGrade = new List<double>();
        public string passed { get; set; }
        public void ComputeGrade(double quizScore, double examScore)
        {
            FinalGrade = quizScore + examScore;
            FinalGrade = FinalGrade / 4;

            Console.WriteLine("Final Grade: " + FinalGrade);
            if (FinalGrade >= 60)
            {
                Console.WriteLine("PASSED!");
                passed = "PASSED!!";
            }
            else
            {
                Console.WriteLine("FAILED!");
                passed = "FAILED!!";
            }
        }
    }
}
