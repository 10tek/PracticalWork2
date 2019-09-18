using System;

namespace PW2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. y = 7x^2 - 3x + 4;
            /*string number = Console.ReadLine();
            double numberX, numberY;
            if (double.TryParse(number, out numberX))
            {
                numberY = 7 * Math.Pow(numberX, 2) - 3 * numberX + 4;
                Console.WriteLine($"Значение y = {numberY};");
            }
            else
            {
                Console.WriteLine("Неккоректный ввод!");
            }*/

            //2.Дан радиус окружности. Найти длину окружности и площадь круга.
            /*string number = Console.ReadLine();
            double circumference, circulArea, circleRadius;
            if (double.TryParse(number, out circleRadius))
            {
                circumference = Math.PI * Constants.two * circleRadius;
                circulArea = Math.PI * Math.Pow(circleRadius, 2);
                Console.WriteLine($"Длину окружности  = {circumference};\nПлощадь круга = {circulArea};");
            }
            else
            {
                Console.WriteLine("Неккоректный ввод!");
            }*/

            //3.Дано расстояние в сантиметрах.Найти число полных метров в нем.
            /*string number = Console.ReadLine();
            int centimeter, meter;
            if (int.TryParse(number, out centimeter))
            {
                meter = centimeter / Constants.hundred;
                Console.WriteLine($"Полных метров = {meter};");
            }
            else
            {
                Console.WriteLine("Неккоректный ввод!");
            }*/

            //4.С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
            /*string number = Console.ReadLine();
            int day, week;
            if (int.TryParse(number, out day))
            {
                week = day / Constants.seven;
                Console.WriteLine($"Полных недель = {week};");
            }
            else
            {
                Console.WriteLine("Неккоректный ввод!");
            }*/

            //a.число десятков в нем;
            //b.число единиц в нем;
            //c.сумму его цифр;
            //d.произведение его цифр
            /*string number = Console.ReadLine();
            int doubleDigit, numberTens, numberUnits, numberSum, numberProduction;
            if (int.TryParse(number, out doubleDigit) && IsDoubleDigit(doubleDigit))
            {
                numberTens = doubleDigit / Constants.ten;
                numberUnits = doubleDigit % Constants.ten;
                numberSum = numberTens + numberUnits;
                numberProduction = numberTens * numberUnits;
                Console.WriteLine($"a.Число десятков = {numberTens};");
                Console.WriteLine($"b.Число единиц = {numberUnits};");
                Console.WriteLine($"c.Cуммa его цифр = {numberSum};");
                Console.WriteLine($"d.произведение его цифр = {numberProduction};");
            }
            else
            {
                Console.WriteLine("Неккоректный ввод!");
            }*/

            //6.Дано четырехзначное число. Найти:
            //a.сумму его цифр;
            //b.произведение его цифр.
            /*string number = Console.ReadLine();
            int FourDigit, numberSum = 0, numberProduction = 1;
            if (int.TryParse(number, out FourDigit) && IsFourDigit(FourDigit))
            {
                for(int tmpNumber = FourDigit; tmpNumber > 0; tmpNumber /= Constants.ten)
                {
                    numberSum += tmpNumber % Constants.ten;
                    numberProduction *= tmpNumber % Constants.ten;
                }
                Console.WriteLine($"c.Cуммa его цифр = {numberSum};");
                Console.WriteLine($"d.произведение его цифр = {numberProduction};");
            }
            else
            {
                Console.WriteLine("Неккоректный ввод!");
            }*/

            //456 / 100 + (456 % 10) * 10 + 456 / 10 % 10; 
            //7.В трехзначном числе x зачеркнули его вторую цифру.
            //Когда к образованному при этом двузначному числу справа приписали вторую цифру числа x, то получилось число 456.Найти число x.
            /*string number = Console.ReadLine();
            int threeDigit, resultNumber;
            if (int.TryParse(number, out threeDigit) && IsThreeDigit(threeDigit))
            {
                resultNumber = (threeDigit / Constants.hundred) * Constants.hundred + (threeDigit % Constants.ten) * Constants.ten + threeDigit / Constants.ten % Constants.ten;
                Console.WriteLine($"Число x = {resultNumber};");
            }
            else
            {
                Console.WriteLine("Неккоректный ввод!");
            }*/

            //a.не X и не Y;
            //b.X или(не X и Y);
            //c.  (не X и Y) или Y.
            bool isX = true;
            bool isY = true;
            bool result;
            result = !isX && !isY;
            result = isX || (!isX && isY);
            result = (!isX && isY) || isY;



            Console.ReadKey();
        }

        public static bool IsDoubleDigit(int number)
        {
            return (number / Constants.ten < Constants.ten && number * Constants.ten >= Constants.hundred);
        }

        public static bool IsFourDigit(int number)
        {
            return (number / Constants.ten < Constants.thousand && number * Constants.ten >= Constants.tenThousand);
        }

        public static bool IsThreeDigit(int number)
        {
            return (number / Constants.ten < Constants.hundred && number * Constants.ten >= Constants.thousand);
        }
    }
}
