using Xunit;
using oop_assignment_2_2025_75225.Questions;
using System.Collections.Generic;

namespace Exam.Tests
{
    public class ExamQuestion1_Tests
    {
        [Theory]
        [InlineData("0831234567", true)]
        [InlineData("0899988776", true)]
        [InlineData("0812345678", false)]
        [InlineData("083 1234567", false)]
        [InlineData("08312345678", false)]
        public void IsValidIrishMobile_ShouldValidateCorrectly(string phone, bool expected)
        {
            Assert.Equal(expected, ExamQuestion_1.IsValidIrishMobile(phone));
        }

        [Theory]
        [InlineData("Bronze", 1)]
        [InlineData("Silver", 5)]
        [InlineData("Gold", 10)]
        [InlineData("Platinum", 15)]
        [InlineData("Diamond", 20)]
        [InlineData("Elite", 25)]
        [InlineData("VIP", 30)]
        [InlineData("Unknown", 0)]
        public void GetDiscountPercentage_ShouldReturnCorrectDiscount(string level, int expected)
        {
            Assert.Equal(expected, ExamQuestion_1.GetDiscountPercentage(level));
        }
    }
}
