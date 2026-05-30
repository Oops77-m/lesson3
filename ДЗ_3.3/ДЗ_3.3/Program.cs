namespace ДЗ_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Солнце";
            string word2 = "Дождь";
            string word3 = "Снег";
            string word4 = "Ветер";
            string word5 = "Шторм";
            string word6 = "Погода";
            string word7 = "Температура";
            string word8 = "Холод";
            string word9 = "Мороз";
            string word10 = "Жарко";

            Console.WriteLine("Введите слово с заглавной буквы на русском языке о погоде: ");
            string word = Console.ReadLine();

            if (word == word1) { Console.WriteLine("Sun"); }
            else if (word == word2) { Console.WriteLine("Rain"); }
            else if (word == word3) { Console.WriteLine("Snow"); }
            else if (word == word4) { Console.WriteLine("Wind"); }
            else if (word == word5) { Console.WriteLine("Storm"); }
            else if (word == word6) { Console.WriteLine("Weather"); }
            else if (word == word7) { Console.WriteLine("Temperature"); }
            else if (word == word8) { Console.WriteLine("Cold"); }
            else if (word == word9) { Console.WriteLine("Frost"); }
            else if (word == word10) { Console.WriteLine("Hot"); }
            else { Console.WriteLine("Такого слова нет :("); }

        }
    }
}
