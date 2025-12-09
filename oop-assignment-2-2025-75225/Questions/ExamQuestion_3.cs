using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop_assignment_2_2025_75225.Questions
{
    public static class ExamQuestion_3
    {
        public static double CalculateAverage(List<int> ratings)
        {
            if (ratings == null || ratings.Count == 0)
                return 0;

            return Math.Round(ratings.Average(), 1);
        }
        public static (string ProductName, double Average) GetTopRatedProduct(List<(string Name, List<int> Ratings)> products)
        {
            string bestProduct = "";
            double bestAverage = 0;

            foreach (var p in products)
            {
                double avg = CalculateAverage(p.Ratings);

                if (avg > bestAverage)
                {
                    bestAverage = avg;
                    bestProduct = p.Name;
                }
            }

            return (bestProduct, bestAverage);
        }
        public static string AnalyzeProducts(List<(string Name, List<int> Ratings)> products)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var product in products)
            {
                if (product.Ratings == null || product.Ratings.Count == 0)
                {
                    sb.AppendLine($"{product.Name}: No ratings available");
                }
                else
                {
                    double avg = CalculateAverage(product.Ratings);
                    sb.AppendLine($"{product.Name}: Average Rating = {avg}");
                }
            }

            var top = GetTopRatedProduct(products);
            if (!string.IsNullOrEmpty(top.ProductName))
            {
                sb.AppendLine($"The top-rated product is {top.ProductName} with an average rating of {top.Average}");
            }

            return sb.ToString();
        }
        public static void Run()
        {
            Console.WriteLine("\n     Exam Question 3\n");

            var products = new List<(string Name, List<int> Ratings)>
            {
                ("Laptop", new List<int> {5,4,4,5,3}),
                ("Headphones", new List<int> {4,3,5}),
                ("Keyboard", new List<int> {5,5,5,4}),
                ("Mouse", new List<int> {3,3,4})
            };

            string report = AnalyzeProducts(products);
            Console.WriteLine(report);
        }
    }
}
