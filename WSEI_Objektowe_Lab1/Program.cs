using System;
using System.Collections.Generic;

namespace WSEI_Objektowe_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IShape>()
            {
                new Rectangle(),
                new Square()
            };
            while (true)
            {
                for (int i = 0; i < shapes.Count; i++)
                {
                    Console.WriteLine($"Wpisz {i + 1} aby policzyć pole {shapes[i].Name}");
                }
                Console.WriteLine("Wpisz Q aby zakonczyć");

                var userInput = Console.ReadLine();

                if (userInput.ToLower() == "q")
                    break;
                int index;

                if (!Int32.TryParse(userInput, out index) || index > shapes.Count)
                    throw new ArgumentException("podano niepoprawny argument");

                shapes[index - 1].GetData();
                shapes[index - 1].CalculateArea();
            }

        }


    }
}
