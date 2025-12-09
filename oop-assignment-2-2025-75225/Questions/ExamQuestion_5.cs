using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_2_2025_75225.Questions
{
    public static class ExamQuestion_5
    {
        public static void Run()
        {
            Console.WriteLine("\n   Exam Question 5    \n");
            Console.WriteLine("Question 5A - Date Formatting:");

            DateTime date = new DateTime(2025, 7, 4);

            Console.WriteLine(FormatDate(date));
            Console.WriteLine("\nQuestion 5B - Current Time:");
            Console.WriteLine(GetCurrentTime12Hour());
            Console.WriteLine("\nQuestion 5C - Date Conversion:");
            Console.WriteLine(ConvertDateFormat("2025-11-30"));
        }

        public static string FormatDate(DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }
        public static string GetCurrentTime12Hour()
        {
            return DateTime.Now.ToString("hh:mm tt");
        }
        public static string ConvertDateFormat(string dateString)
        {
            DateTime parsedDate = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            return parsedDate.ToString("dddd, dd MMMM yyyy");
        }
    }
}