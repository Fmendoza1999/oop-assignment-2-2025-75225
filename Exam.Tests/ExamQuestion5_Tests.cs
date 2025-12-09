using Xunit;
using oop_assignment_2_2025_75225.Questions;
using System;

namespace Exam.Tests
{
    public class ExamQuestion5_Tests
    {
        [Theory]
        [InlineData(2025, 7, 4, "04/07/2025")]
        [InlineData(2025, 1, 1, "01/01/2025")]
        [InlineData(2025, 12, 31, "31/12/2025")]
        public void FormatDate_ShouldReturnCorrectFormat(int y, int m, int d, string expected)
        {
            Assert.Equal(expected, ExamQuestion_5.FormatDate(new DateTime(y, m, d)));
        }

        [Fact]
        public void GetCurrentTime12Hour_ShouldReturnValidFormat()
        {
            string result = ExamQuestion_5.GetCurrentTime12Hour();
            Assert.Matches(@"^\d{2}:\d{2} (AM|PM)$", result);
        }

        [Theory]
        [InlineData("2025-11-30", "Sunday, 30 November 2025")]
        [InlineData("2025-01-01", "Wednesday, 01 January 2025")]
        public void ConvertDateFormat_ShouldConvertCorrectly(string input, string expected)
        {
            Assert.Equal(expected, ExamQuestion_5.ConvertDateFormat(input));
        }
    }
}
