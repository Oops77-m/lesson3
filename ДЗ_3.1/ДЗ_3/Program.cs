using System.ComponentModel.Design;

namespace ДЗ_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 4;
            int operand2 = 2;
            Console.WriteLine("Введите знак арифметической операции: ");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    {
                        Console.WriteLine(operand1 + operand2);
                    } break;
                case "-":
                    {
                        Console.WriteLine(operand1 - operand2);
                    }
                    break;
                case "*":
                    {
                        Console.WriteLine(operand1 * operand2);
                    }
                    break;
                case "/":
                    {
                        if (operand2 == 0) { Console.WriteLine("Ошибка. На 0 делить нельзя!"); }
                    else
                        {
                            Console.WriteLine(operand1 / operand2);

                        }
                    }
                    break;

            }




        }
    }
}
    
