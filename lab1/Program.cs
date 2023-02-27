using System;

namespace lab1;
class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
    }
    static void Task1()
    {
        Console.WriteLine("Введіть число n (0<n<1): ");
        double number = Convert.ToDouble(Console.ReadLine());
        string intPart;
        if (number < 1 && number > 0)
        {
            intPart = "0";
        }
        else
        {
            intPart = "";
        }
        int intPartInt = (int)number;
        double fractPartDouble = number - intPartInt;
        string fractPart = "";
        while (intPartInt != 0)
        {
            int remainder = intPartInt % 8;
            intPart = remainder.ToString() + intPart;
            intPartInt /= 8;
        }
        while (fractPartDouble != 0 && fractPart.Length < 7)
        {
            fractPartDouble *= 8;
            int integer = (int)fractPartDouble;
            fractPart += integer.ToString();
            fractPartDouble = fractPartDouble - (int)fractPartDouble;
        }
       
        Console.WriteLine($"Число {number} у вісімковій системі числення: {intPart}.{fractPart}");
    }

    static void Task2()
    {
        Console.WriteLine("Введіть x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть z: ");
        double z = Convert.ToDouble(Console.ReadLine());
        double prod = x * y * z;
        double value = 1000 + Math.Pow(Math.Log(24), 1/2);
        double a = (prod - 3 * Math.Abs(x + Math.Pow(y, 1/3))) / value;
        double b = value * Math.Sin(prod) - Math.Cos(prod) * Math.Cos(prod);
        double c = prod - ((prod * prod * prod) / 6);
        double maxVal = Math.Max(a, b);
        double minVal = Math.Min(maxVal, c);
        Console.WriteLine($"a = {a}\nb = {b}\nc = {c}\nmin(max(a, b), c) = {minVal}");
    }

    static void Task3()
    {
        double[,] matrix = new double[7, 5] {{7.8, 6.7, -9.0, 13.5, 12.0},
        {-11.4, -7.0, 3.0, 4.5, 5.6}, {15.7, -3.8, 1.5, 5.0, 2.9},
        {7.8, -14.6, 18.1, -9.4, -11.0}, {-5.8, 8.0, -4.4, -4.0, -10.8},
        {13.3, 15.7, 8.0, -9.0, 5.5}, {-20.2, 6.7, 7.4, 6.2, -19}};
        /*double[,] matrix = new double[7, 5] {{2.3, 1.4, -5.0, 4.0, 2.4},
        {-2.3, 9.4, -3.0, -1.0, 5.9}, {15.7, -3.8, 1.5, 5.0, 2.9},
        {4.7, 2.4, -1.0, 2.2, 2.0}, {5.8, -8.0, 4.4, 4.0, 10.8},
        {4.0, -12.0, -14.9, 5.0, 4.2}, {7.3, 8.9, 0.0, 18.6, 1.8}};*/
        Console.WriteLine("Матриця А:\n"); 
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(string.Format("{0} ", matrix[i, j]));
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }
        double[] vector = new double[5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (matrix[j,i] >= 0)
                {
                    vector[i] += matrix[j, i];
                }
            }
        }
        Console.WriteLine("Вектор суми додатніх елементів стовбців:\n");
        double minElement = vector[0];
        for (int i = 0; i < 5; i++)
        {
            if (vector[i]<minElement)
            {
                minElement = vector[i];
            }
            Console.WriteLine(vector[i]);
        }
        Console.WriteLine($"\nМінімальний елемент вектора: {minElement}");
    }
    
}

