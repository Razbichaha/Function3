using System;

namespace Function3
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputPlaer = 0;

            
            Console.Write("Вы  ввели число - " + GetNumber(inputPlaer));
            Console.ReadKey();
        }

        static int GetNumber(int inputPlaer )
        {
            inputPlaer = 0;
            bool isNumber = true;

            while (isNumber)
            {
                Console.Write("Введите число ");
                string stringTemp = Console.ReadLine();

                if(int.TryParse(stringTemp, out inputPlaer))
                {
                    isNumber = false;
                }
                Console.Clear();
            }
            return inputPlaer;
        }
    }
}
