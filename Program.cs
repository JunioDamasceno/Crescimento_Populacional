﻿using System;

namespace Crescimento_Populacional
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb;
            int anos;

            for (int i = 0; i< t; i++)
            {
                anos = 0;
                string[] valores = Console.ReadLine().Split();
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);

                cpa = double.Parse(valores[2]);
                cpb = double.Parse(valores[3]);

                while (pa <= pb)
                {
                    pa = (int)(pa + (pa * (cpa/100)));
                    pb = (int)(pb + (pb * (cpb/100)));
                    anos++;

                    if (anos > 100)
                    {
                        Console.WriteLine("Mais de 1 seculo.");
                        pa = pb + 1;
                    }
                    
                }

                if (anos <= 100)
                {
                    Console.WriteLine($"{anos} anos.");
                }
                
                

            }
        }
    }
}
