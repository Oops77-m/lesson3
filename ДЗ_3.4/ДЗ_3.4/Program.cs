namespace ДЗ_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Проверим число на четность! Введите целое число: ");
            string input2=Console.ReadLine();
            int value2 = int.Parse(input2);

            if (value2 % 2 == 0) {
                Console.WriteLine("Чётное");
            }
            else { Console.WriteLine("Нечётное"); }
        }
    }
}
