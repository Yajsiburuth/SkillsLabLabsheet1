using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MainLogic
    {
       enum Category
        {
            E = 20,
            D = 40,
            C = 60,
            B = 80,
            A = 100
        }

        public void DisplayCategory()
        {
            int lower_limit = 0;
            foreach (int i in Enum.GetValues(typeof(Category)))
            {
                Console.WriteLine("Category: " + Enum.GetName(typeof(Category), i) + " has the range of " + lower_limit + " - " + i);
                lower_limit = i + 1;
            }
        }

        public void CheckCategory(int inputNumber)
        {
            foreach (int i in Enum.GetValues(typeof(Category)))
            {
                if (inputNumber <= i)
                {
                    Console.WriteLine("Category: " + Enum.GetName(typeof(Category), i));
                    break;
                }
            }
        }

        public void Launcher()
        {
            int invalidNumber = -1;
            int inputNumber;

            while (true)
            {
                DisplayCategory();
                inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber == invalidNumber)
                    break;
                CheckCategory(inputNumber);
            }

        }

    }
}
