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
                Console.Clear();
                Start();
            }
            catch (IncorrectInputException ex) { Console.WriteLine($"{ex.Message}"); }
            catch (Exception ex) { Console.WriteLine($"{ex.Message}"); }

            // Console.Write($"Для выбора укажите номер операции:");
            // string? value = Console.ReadLine();
            // ConsoleKeyInfo inp = Console.ReadKey(false);
            // Console.WriteLine($"{inp.Key}\n");
            // if (inp.c != 13) 
            // { 
            //     Console.WriteLine($"{inp} ===");
            //     if (int.TryParse(inp.KeyChar, out int number))  { Console.WriteLine("Число."); }
            //     else { Console.WriteLine("Не число."); }
                 
            // }
            // else 
            // {
            //     Console.WriteLine("Клавиша считана!"); 
            // }
            // if (int.TryParse(value, out int number)) { Console.WriteLine("Катируется!"); }
            // else { Console.WriteLine("Не катируется..."); }
        }
    }
}




