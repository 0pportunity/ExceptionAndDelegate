using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class NumberReader
    {
        public delegate void NumberEnteredDelegate(int number);

        public event NumberEnteredDelegate NumberEnteredEvent; 

        public void ReadNumber()
        {
            Console.WriteLine("Сортировка А-Я - введите 1; сортировка Я-А - введите 2.");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2) throw new InputException("Введите либо 1, либо 2!");

            NumberEntered(number);
        }

        protected virtual void NumberEntered (int number)
        {
            NumberEnteredEvent?.Invoke(number);
        }
    }
}
