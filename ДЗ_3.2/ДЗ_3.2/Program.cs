namespace ДЗ_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 0 до 100 и узнайте в какой числовой промежуток оно входит: ");
            string input = Console.ReadLine();
            int value = int.Parse(input);

            if (value >= 0 & value <= 14) { Console.WriteLine("Промежуток [0-14]"); }

            else if (value >= 15 & value <= 35) { Console.WriteLine("Промежуток [15-35]"); }
            else if (value >= 36 & value <= 50) { Console.WriteLine("Промежуток [36-50]"); }
            else if (value >= 50 & value <= 100) { Console.WriteLine("Промежуток [51-100]"); }
            else { Console.WriteLine("Не входит ни в один промежуток"); }
                   




        }
    }
}
