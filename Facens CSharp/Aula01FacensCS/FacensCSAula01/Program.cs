﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01FacensCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Fatorial();

            int a, b, c;
            double delta, a1, a2;

            Console.WriteLine("Digite o valor de a:\n");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de b:\n");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de c:\n");
            c = -(Convert.ToInt32(Console.ReadLine()));

            delta = (b * b) - (4 * a * c);
            a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Raiz 1 = " 
                              + a1
                              + "\nRaiz 2 = "
                              + a2);
            Console.ReadKey();
        }
        #region Funcoes
        public static void Fatorial()
        {
            int fatorial = 0, resultado = 1;
            Console.WriteLine("Digite o número que deseja saber o fatorial: ");
            fatorial = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (fatorial < 0) Console.WriteLine("Somente números positivos são permitidos");
                if (fatorial <= 1)
                    fatorial = 1;
                else
                {
                    for (int numeroFatorial = 1; numeroFatorial < fatorial; numeroFatorial++)
                    {
                        resultado += resultado * numeroFatorial;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Informe apenas números e números positivos...");
            }
            Console.WriteLine(fatorial.ToString() + "! = " + resultado.ToString());
        }

        #endregion

        #region Lacos
        public static void lacoFor()
        {
            int contador = 10;
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("Número " + i);
            }
        }
        public static void lacoWhile()
        {
            int contador = 10;
            int j = 0;
            while (j < contador)
            {
                Console.WriteLine("While " + j);
                j++;
            }
        }
        public static void lacoDoWhile()
        {
            int contador = 10;
            int k = 0;
            do
            {
                Console.WriteLine("Do While " + k);
                k++;
            } while (k < contador);
        }
        #endregion
    }
}
