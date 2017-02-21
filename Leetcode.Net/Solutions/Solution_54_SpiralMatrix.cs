using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_54_SpiralMatrix
    {
        public void Run()
        {
            IList<int> list = SpiralOrder(new int[,] { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } });

            //int[,] arr = new int[,] { { 1, 2 }, { 3, 4 } };
            //IList<int> list = SpiralOrder(arr);

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");

                Console.WriteLine("");
            }
        }


        public IList<int> SpiralOrder(int[,] matrix)
        {
            IList<int> result = new List<int>();
            SpiralOrder(result, matrix, 0, 0, matrix.GetLength(0), matrix.GetLength(1));
            return result;  
        }

        public void SpiralOrder(IList<int> result, int[,] matrix, int dimenOneStart, int dimenTwoStart, int dimenOneSize, int dimenTwoSize)
        {
            int d1 = dimenOneStart;
            int d2 = dimenTwoStart;

            if (dimenOneSize > 0 && dimenTwoSize > 0)
            {
                for (int i = 0; i < dimenTwoSize; i++, d2++)
                {
                    result.Add(matrix[d1, d2]);
                }

                d2 = dimenTwoStart + dimenTwoSize - 1;
                for (int i = 0; i < dimenOneSize - 1; i++)
                {
                    result.Add(matrix[++d1, d2]);
                }

                for (int i = 0; i < dimenTwoSize - 1 && dimenOneSize >= 2; i++)
                {
                    result.Add(matrix[d1, --d2]);
                }

                for (int i = 0; i < dimenOneSize - 2 && dimenTwoSize >= 2; i++)
                {
                    result.Add(matrix[--d1, d2]);
                }

                SpiralOrder(result, matrix, dimenOneStart + 1, dimenTwoStart + 1, dimenOneSize - 2, dimenTwoSize - 2);
            }
        }


        public void GenerateMatrix(int startFS, int size, int startNumber, int[,] result)
        {
            int startF = startFS;
            int startS = startFS;

            if (size > 0)
            {
                for (int index = 0; index < size; index++)
                {
                    result[startF, startS + index] = startNumber;
                    startNumber++;
                }

                startS = startFS + size - 1;
                for (int i = 1; i < size; i++)
                {
                    result[startF + i, startS] = startNumber;
                    startNumber++;
                }

                startF = startFS + size - 1;
                for (int i = 1; i < size && size >= 2; i++)
                {
                    result[startF, startS - i] = startNumber;
                    startNumber++;
                }

                startS = startFS;
                for (int i = 1; i < size - 1 && size >= 2; i++)
                {
                    result[startF - i, startS] = startNumber;
                    startNumber++;
                }

                GenerateMatrix(startFS + 1, size - 2, startNumber, result);
            }
        }
    }
}
