using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_2_2025_75225.Questions
{
    public static class ExamQuestion_2
    {
        public static void Run()
        {
            Console.WriteLine("\n  Exam Question 2    n");
            Console.WriteLine("Question 2A - Safe Division:");
            Console.WriteLine(Divide(10, 2));
            Console.WriteLine(Divide(10, 0));
            Console.WriteLine("\nQuestion 2B - Safe Conversion:");
            Console.WriteLine(ConvertToInt("123"));
            Console.WriteLine(ConvertToInt("abc"));
            Console.WriteLine("\nQuestion 2C - User Registration:");
            Console.WriteLine(RegisterUser(25));
            Console.WriteLine(RegisterUser(15));
        }
        public static string Divide(int a, int b)
        {
            try
            {
                int result = a / b;
                return result.ToString();
            }
            catch (DivideByZeroException)
            {
                return "Cannot divide by 0";
            }
        }

        public static string ConvertToInt(string input)
        {
            try
            {
                int result = int.Parse(input);
                return result.ToString();
            }
            catch (FormatException)
            {
                return "Invalid number entered.";
            }
        }
        public static string RegisterUser(int age)
        {
            try
            {
                if (age < 18)
                {
                    throw new ArgumentOutOfRangeException(nameof(age), "Age must be at least 18");
                }
                return "Registration successful.";
            }
            catch (ArgumentOutOfRangeException)
            {
                return "User must be at least 18 to register.";
            }
        }
    }
}