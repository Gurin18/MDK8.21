using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void ShopIncome()
        {
            Console.WriteLine("Глава 8, задание 8.21");
            Console.WriteLine("----------------------");
            int i, D, k, k1, k2, max1, max2, max3, T1, T2, T3;
            string st;
            k = 0; k1 = 0; k2 = 0;
            max1 = 0; max2 = 0; max3 = 0;
            D = 10;
            int[] A;
            int[] B;
            int[] C;
            A = new int[D];
            for (i = 0; i < D; i++)
            {
                k++;
                Console.WriteLine("Введите доход первого магазина за " + k + " день");
                st = Console.ReadLine();
                A[i] = Convert.ToInt32(st);
                if (A[i] > A[max1]) max1 = i;
                T1 = A[0]; A[0] = A[max1]; A[max1] = T1;

            }
            Console.WriteLine("Максимальная прибыль получена на " + (max1 + 1) + " день");
            Console.WriteLine("----------------------");
            B = new int[D];
            for (i = 0; i < D; i++)
            {
                k1++;
                Console.WriteLine("Введите доход второго магазина за " + k1 + " день");
                st = Console.ReadLine();
                B[i] = Convert.ToInt32(st);
                if (B[i] > B[max2]) max2 = i;
                T2 = B[0]; B[0] = B[max2]; B[max2] = T2;
            }
            Console.WriteLine("Максимальная прибыль получена на " + (max2 + 1) + " день");
            Console.WriteLine("----------------------");
            C = new int[D];
            for (i = 0; i < D; i++)
            {
                k2++;
                Console.WriteLine("Введите доход третьего магазина за " + k2 + " день");
                st = Console.ReadLine();
                C[i] = Convert.ToInt32(st);
                if (C[i] > C[max3]) max3 = i;
                T3 = C[0]; C[0] = C[max3]; C[max3] = T3;
            }
            Console.WriteLine("Максимальная прибыль получена на " + (max3 + 1) + " день");
            Console.WriteLine("----------------------");

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            ShopIncome();
        }
    }

