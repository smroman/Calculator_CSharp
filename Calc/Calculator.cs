using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace CalculatorNamespace
{
    public static class Calculator
    {
        public static void Start()
        {
            try
            {   
                Console.WriteLine($"========================================");
                Console.WriteLine($"Выберите необходимую операцию из списка:\n");
                Console.WriteLine($"1 - Сложение.\n");
                Console.WriteLine($"9 - Режим свободного ввода.\n");
                Console.WriteLine($"Esc - Закрыть приложение.\n");
                Console.WriteLine($"========================================\n");

                Console.Write($"Для выбора укажите номер операции:");
                ConsoleKeyInfo inputKey = Console.ReadKey(false);
                switch (inputKey.Key)
                {
                    case ConsoleKey.Escape:
                    break;

                    case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine($"{Math.Round(Sum(), 4)}");
                    Start();
                    break;

                    case ConsoleKey.D9:
                    FreeInputStart();
                    break;

                    default:
                    Console.Clear();
                    Console.WriteLine($"Введён некорректный номер.\n");
                    Start();
                    break;
                }   
            }
            catch(Exception ex) {throw new UnknowException("Start", ex); };
        }

        public static void SysStart(int operationId)
        {
            try
            {                
                switch (operationId)
                {
                    case 1:
                    Console.WriteLine($"Результат сложения: {Math.Round(Sum(), 4)}");
                    Start();
                    break;
                }   
            }
            catch(Exception ex) {throw new UnknowException("SysStart", ex); };
        }

        public static void FreeInputStart()
        {
            Console.Clear();
            Console.WriteLine($"Вы перешли в режим свободного ввода. Для выхода нажмите 'Enter' не вводя ничего в консоль.\n");
            string? input = Console.ReadLine();
            if (input == null) 
            { 
                Console.Clear(); 
                Start(); 
            }
            string text = input.Replace(" ", "");
            Console.WriteLine($"{text}");
            // string[] words = input.Trim().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        }

        public static double Sum()
        {
            try
            {
            Console.WriteLine($"Введите первое слагаемое:");
            double number1 = InputNumber(1);
            Console.WriteLine($"Введите второе слагаемое:");
            double number2 = InputNumber(1);
            return number1 + number2;
            }
            catch(Exception ex) {throw new UnknowException("Sum", ex); };
        }


        private static double InputNumber(int operationId)
        {
            try
            {
                var inpNumber = Console.ReadLine();
                if (double.TryParse(inpNumber, out double number)) {}
                else { throw new IncorrectInputException(); }
                return number; 
            }
            catch(IncorrectInputException) {throw new IncorrectInputException("InputNumber", operationId); }
            catch(Exception ex) {throw new UnknowException("InputNumber", ex); };
        }
    }

    public sealed class IncorrectInputException : Exception
    {
        const string _ERRORBODY = "Некоректный ввод!";
        public IncorrectInputException() { }
        public IncorrectInputException(string methodName, int operationId) : base($"ERROR {methodName}: {_ERRORBODY}\n") 
        {
            Console.WriteLine($"{Message}");
            Calculator.SysStart(operationId); 
        }
    }

    public sealed class UnknowException : Exception
    {
        public UnknowException(string methodName, Exception ex) : base($"UnknownERROR {methodName}: {ex.Message}\n") { }
    }
}

