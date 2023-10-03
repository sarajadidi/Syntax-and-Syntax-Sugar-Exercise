namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int answer = 4;
            string response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} greater than";

     
            Console.WriteLine(response);

        }
    }
}
