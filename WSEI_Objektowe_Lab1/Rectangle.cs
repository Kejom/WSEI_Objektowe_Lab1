using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSEI_Objektowe_Lab1
{
    class Rectangle : IShape
    {

        private int a;
        private int b;

        public string Name => "Prostokąt";

        public void CalculateArea()
        {
            Console.WriteLine(a*b);
        }

        public void GetData()
        {
            Console.WriteLine("podaj dlugosc pierwszego boku");
            var inputA = Console.ReadLine();

            if (!Int32.TryParse(inputA, out a))
                throw new ArgumentException("podano niepoprawny argument");

            Console.WriteLine("podaj dlugosc drugiego boku");
            var inputB = Console.ReadLine();

            if (!Int32.TryParse(inputB, out b))
                throw new ArgumentException("podano niepoprawny argument");
        }
    }
}
