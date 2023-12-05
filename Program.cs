using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLenght
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double[,] matriz2D = { {1,2,3},
                                    {4,5,6} };
            ImprimirMatrizMulti(matriz2D);
        }

        static void ImprimirMatrizMulti(double[,] matriz2DPa)
        {
            int i, j;
            for (i = 0; i < matriz2DPa.GetLength(0); i++)
            {
                Console.WriteLine("fila {0}", i);
                for (j = 0; j < matriz2DPa.GetLength(1); j++)
                {
                    Console.WriteLine(matriz2DPa[i, j]);
                }
            }
        }
    }

}
