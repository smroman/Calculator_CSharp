using CalculatorNamespace;
using static CalculatorNamespace.Calculator;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Start();
            }
            catch (IncorrectInputException ex) { Console.WriteLine($"{ex.Message}"); }
            catch (Exception ex) { Console.WriteLine($"{ex.Message}"); }
        }
    }
}




