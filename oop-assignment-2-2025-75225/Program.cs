using oop_assignment_2_2025_75225.Questions;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            ExamQuestion_1.Run();
            ExamQuestion_2.Run(); 
            ExamQuestion_3.Run();
            ExamQuestion_5.Run();  
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nError: " + ex.Message);
            Console.WriteLine($"Stack Trace: {ex.StackTrace}");
        }

        Console.WriteLine("\nExecution Complete");
    }
}
