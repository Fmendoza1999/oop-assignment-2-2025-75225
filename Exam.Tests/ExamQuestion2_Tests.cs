using Xunit;
using oop_assignment_2_2025_75225.Questions;

namespace Exam.Tests
{
    public class ExamQuestion2_Tests
    {
        [Theory]
        [InlineData(10, 2, "5")]
        [InlineData(10, 0, "Cannot divide by 0")]
        [InlineData(20, 4, "5")]
        public void Divide_ShouldHandleAllCases(int a, int b, string expected)
        {
            Assert.Equal(expected, ExamQuestion_2.Divide(a, b));
        }

        [Theory]
        [InlineData("123", "123")]
        [InlineData("abc", "Invalid number entered.")]
        [InlineData("456", "456")]
        [InlineData("xyz", "Invalid number entered.")]
        public void ConvertToInt_ShouldHandleAllCases(string input, string expected)
        {
            Assert.Equal(expected, ExamQuestion_2.ConvertToInt(input));
        }

        [Theory]
        [InlineData(25, "Registration successful.")]
        [InlineData(15, "User must be at least 18 to register.")]
        [InlineData(18, "Registration successful.")]
        [InlineData(17, "User must be at least 18 to register.")]
        public void RegisterUser_ShouldHandleAllCases(int age, string expected)
        {
            Assert.Equal(expected, ExamQuestion_2.RegisterUser(age));
        }
    }
}
