using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSEI_Objektowe_Lab1
{
    class Square : IShape
    {
        private int a;


        public int CalculateArea()
        {
            return a * a;
        }

        public void GetData()
        {
            Console.WriteLine("podaj dlugosc boku");
            int a = Int32.Parse(Console.ReadLine());
        }
    }
}
