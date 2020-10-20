using System;

namespace ISMDotNet3
{
    class Program
    {
        static double SumOfNegativeNumbers(double[] a)
        {
            double sum = 0;
            for(int i = 0; i < a.Length; i+=1)
            {
                if (a[i] < 0)
                {
                    sum += a[i];
                }
            }
            return sum;
        }


        static double Max(double[] a)
        {
            double max = a[0];

            for(int i = 0; i < a.Length; i+=1)
            {
                if(max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }


        static int IndexOfMax(double[] a)
        {
            double max = a[0];
            int max_ind = 0;
            for(int i = 0; i < a.Length; i+=1)
            {
                if(max < a[i])
                {
                    max = a[i];
                    max_ind = i;
                }
            }
            return max_ind;
        }


        static double AbsMax(double[] a)
        {
            double max = Math.Abs(a[0]);

            for (int i = 0; i < a.Length; i += 1)
            {
                if (max < Math.Abs(a[i]))
                {
                    max = Math.Abs(a[i]);
                }
            }
            return max;
        }


        static double SumPositiveNumIndexes(double[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i += 1)
            {
                if (a[i] > 0)
                {
                    sum += i;
                }
            }
            return sum;
        }


        static int AmountOfPositiveNumbers(double[] a)
        {
            int num = 0;
            for (int i = 0; i < a.Length; i+=1)
            {
                if (a[i] >= 0)
                    num++;
            }
            return num;
        }


        static int AmountOfIntegers(double[] a)
        {
            int num = 0;
            for (int i = 0; i < a.Length; i += 1)
            {
                if (Math.Truncate(a[i]) == a[i])
                {
                    num += 1;
                }
            }
            return num;
        }


        static void DescendingOrder(double[] a)
        {
            double saver;

            for(int i = 0; i < a.Length-1; i+=1)
            {
                for (int j = i + 1; j < a.Length; j += 1)
                {
                    if (a[i] < a[j])
                    {
                        saver = a[i];
                        a[i] = a[j];
                        a[j] = saver;
                    }
                    else {}
                }
            }
        }


        static double[] DeleteNegativeNumbers(double[] a)
        {
            double[] newArray = new double[AmountOfPositiveNumbers(a)];
            int j = 0;

            for(int i = 0; i < a.Length; i+=1)
            {
                if(a[j] >= 0)
                {
                    newArray[j] = a[i];
                    j++;
                }
            }
            return newArray;
        }


        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Введiть кiлькiсть елементiв у масивi:");
            while (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
            {
                Console.WriteLine("Число повинне бути цiлим i бiльшим за нуль!");
                Console.WriteLine("Введiть кiлькiсть елементiв у масивi:");
            }
            double[] array = new double[num];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Число {0} = ", i);
                while (!double.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Вводити лише числа!");
                    Console.Write("Число {0} = ", i);
                }
            }

            Console.WriteLine($"Сума вiд'ємних елементiв: {SumOfNegativeNumbers(array)}");
            Console.WriteLine($"Mаксимальний елемент масиву: {Max(array)}");
            Console.WriteLine($"Iндекс максимального елемента масиву: {IndexOfMax(array)}");
            Console.WriteLine($"Максимальний за модулем елемент масиву: {AbsMax(array)}");
            Console.WriteLine($"Сума iндексів додатних елементiв: {SumPositiveNumIndexes(array)}");
            Console.WriteLine($"Кiлькiсть цiлих чисел у масивi: {AmountOfIntegers(array)}");
            Console.WriteLine($"Ваш масив виглядав так: ");

            for(int i = 0; i < array.Length; i+=1)
            {
                Console.Write($"{array[i]}  ");
            }
            Console.WriteLine("");

            Console.WriteLine($"Ваш масив пiсля вiдсортування в порядку спадання: ");
            DescendingOrder(array);

            for (int i = 0; i < array.Length; i += 1)
            {
                Console.Write($"{array[i]}  ");
            }
            Console.WriteLine("");

            Console.WriteLine($"Ваш масив пiсля видалення з нього вiд'ємних елементiв: ");
            //DeleteNegativeNumbers(array);
            array = DeleteNegativeNumbers(array);

            for (int i = 0; i < array.Length; i += 1)
            {
                Console.Write($"{array[i]}  ");
            }

        }
    }
}