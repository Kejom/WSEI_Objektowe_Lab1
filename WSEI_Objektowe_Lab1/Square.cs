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

        public string Name => "Kwadrat";

        public void CalculateArea()
        {
            Console.WriteLine(a*a);
        }

        public void GetData()
        {
            
            Console.WriteLine("podaj dlugosc boku");
            var userInput = Console.ReadLine();

            if (!Int32.TryParse(userInput, out a))
                throw new ArgumentException("podano niepoprawny argument");
        }
    }
}
