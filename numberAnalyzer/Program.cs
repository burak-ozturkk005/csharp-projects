namespace numberAnalyzer
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter a number to analyze: ");
            string input = Console.ReadLine();

            if(int.TryParse(input, out int number))
            {
                NumberAnalyzer analyzer = new NumberAnalyzer(number);
                analyzer.isAnalyze();
            }
            else
            {
                Console.WriteLine("Invalid input. please Enter a integer number.");
            }
          
        }
    }
}
