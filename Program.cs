using System;

namespace Function3
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputPlaer = 0;

            OutputMenu(out inputPlaer);
            
            Console.Write("Вы  ввели число - " + inputPlaer);
            Console.ReadKey();
        }

        static void OutputMenu(out int inputPlaer )
        {
            inputPlaer = 0;
            bool thisIsInputOfValue = true;

            while (thisIsInputOfValue)
            {
                Console.Write("Введите число ");
                string stringTemp = Console.ReadLine();

                if(int.TryParse(stringTemp, out inputPlaer))
                {
                    thisIsInputOfValue = false;
                }else
                {
                    stringTemp = "";
                }
                Console.Clear();
            }
        }
    }
}
