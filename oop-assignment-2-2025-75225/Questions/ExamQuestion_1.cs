using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace oop_assignment_2_2025_75225.Questions
{
    public static class ExamQuestion_1
    {
        public static void Run()
        {
            Console.WriteLine("  Exam Question 1  \n");

            Console.WriteLine("Question 1A - Irish Mobile Number Validation:");
            string[] testNumbers = { "0831234567", "0899988776", "0812345678", "083 1234567", "08312345678" };
            foreach (var number in testNumbers)
            {
                bool isValid = IsValidIrishMobile(number);
                Console.WriteLine($"{number}: {(isValid ? "VALID" : "INVALID")}");
            }

            Console.WriteLine("\nQuestion 1B - Discount Percentages:");
            string[] levels = { "Bronze", "Silver", "Gold", "Platinum", "Diamond", "Elite", "VIP", "Unknown" };
            foreach (var level in levels)
            {
                Console.WriteLine($"{level}: {GetDiscountPercentage(level)}%");
            }
        }
        public static bool IsValidIrishMobile(string phoneNumber)
        {
            string pattern = @"^(083|085|089)\d{7}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        public static int GetDiscountPercentage(string level)
        {
            return level switch
            {
                "Bronze" => 1,
                "Silver" => 5,
                "Gold" => 10,
                "Platinum" => 15,
                "Diamond" => 20,
                "Elite" => 25,
                "VIP" => 30,
                _ => 0 
            };
        }
    }
}