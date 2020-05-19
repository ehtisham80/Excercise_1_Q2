using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Excercise_1_Q2
{
    class Program
    {
        static int GetGrade()
        {
            int grade = 0;
            Console.WriteLine("Please Enter The Grade:");
            String answer = Console.ReadLine();
            Int32.TryParse(answer, out grade);
            return grade;
        }
        static void Main(string[] args)
        {
                   
            int rec_grade = GetGrade();                    
               
            if (rec_grade > 10 || rec_grade < 0)
            {
               Console.WriteLine("Invalid grade! Please use digits 1 to 10 for grading");
            }

            else
            {
                                
                switch (rec_grade)
                {
                    case int n when (n>=0 && n<=4):
                        Console.WriteLine("Fail"+n);
                        break;

                    case int n when (n >= 5 && n < 6):
                        Console.WriteLine("Pass" + n);
                        break;
                    case int n when (n ==6):
                        Console.WriteLine("Good" + n);
                        break;
                    case int n when (n >= 7 && n < 8):
                        Console.WriteLine("Notable" + n);
                        break;
                    case int n when (n >= 9 && n < 10):
                        Console.WriteLine("Excelent" + n);
                        break;

                }
            }
                 
        
        }
    }
}
