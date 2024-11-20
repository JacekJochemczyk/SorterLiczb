using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorterLiczb
{
    internal class SorterLiczb
    {
        private int[] liczby;

        public SorterLiczb()
        {
            liczby = new int[6];
        }

        public void ReadData()
        {
            Console.WriteLine("Podaj 6 liczb całkowitych:");
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.Write($"Liczba {i + 1}: ");
                liczby[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void ProcessData()
        {
            for (int i = 1; i < liczby.Length; i++)
            {
                int key = liczby[i];
                int j = i - 1;

                while (j >= 0 && liczby[j] > key)
                {
                    liczby[j + 1] = liczby[j];
                    j--;
                }

                liczby[j + 1] = key;
            }

        }
        public void ShowResults()
        {
            Console.WriteLine("Posortowane liczby:");
            foreach (int liczba in liczby)
            {
                Console.Write($"{liczba} ");
            }
            Console.WriteLine(); 
        }
    }
}
