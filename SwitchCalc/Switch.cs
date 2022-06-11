using System;

namespace SwitchCalc
{
    class MainClass
    {
        public static void Main(string[] args)
        {
        error: //label for goto
            Console.WriteLine("Введіть операнди:");
            float a, b;
            bool isWight = float.TryParse(Console.ReadLine(), out a);
            if (!isWight)
            {
                Console.WriteLine("Ви ввели неправильні дані. Спробуйте ще раз:");
                goto error;
            }
            isWight = float.TryParse(Console.ReadLine(), out b);
            if (!isWight)
            {
                Console.WriteLine("Ви ввели неправильні дані. Спробуйте ще раз:");
                goto error;
            }
            Console.WriteLine("Яку дію Ви хочете виконати?");
            string choose = Console.ReadLine();

            switch (choose)
            {
                case "+":
                    Console.WriteLine(a + " + " + b + " = " + (a + b));
                    break;
                case "-":
                    Console.WriteLine(a + " - " + b + " = " + (a - b));
                    break;
                case "*":
                    Console.WriteLine(a + " * " + b + " = " + (a * b));
                    break;
                case "/":
                    Console.WriteLine(a + " / " + b + " = " + (a / b));
                    break;
                default:
                    Console.WriteLine("Такої дії не існує.");
                    break;
            }
        }
    }
}
