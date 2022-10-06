using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class mainlogic
    {
        enum Category
        {
            A = 81,
            B = 61,
            C = 41,
            D = 21,
            E = 0
        }

        public void checkCategory()
        {
            foreach(int i in Enum.GetValues(typeof(Category))){
                Console.WriteLine(i);

            }

        }

    }
}
