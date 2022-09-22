using System.Text.RegularExpressions;
namespace Task2
{
    internal class Surnames
    {
        public string[] SurnamesListing { get; private set; }

        public void Input5Surnames()
        {
            Console.WriteLine("Введите последовательно 5 фамилий:");
            SurnamesListing = new string[5];

            for ( int i = 0; i < 5; )
            {
                 string input = Console.ReadLine();

                if (Regex.IsMatch(input, @"^[а-яА-я-]+$"))
                {
                    SurnamesListing[i] = input;
                    i++;
                }
                else
                {
                    Console.WriteLine("Фамилия может содержать только буквы кириллицы и не может содержать никаких цифр и символов, кроме \"-\"");
                }
                
            }
        }
        public void Sort(int number)
        {
            switch (number)
            {
                case 1:
                    Array.Sort(SurnamesListing);
                    break;

                case 2:
                    Array.Sort(SurnamesListing);
                    Array.Reverse(SurnamesListing);
                    break;
            }

            Console.WriteLine("\nРезультат сортировки:\n");
            foreach (string s in SurnamesListing)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
        }

    }
}
