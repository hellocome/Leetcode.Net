using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_223_RectangleArea
    {
        public void Run()
        {
            Console.WriteLine(ComputeArea(-2, -2, 2, 2, 2, -2, 4, 2));
        }

        public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H)
        {
            int first = (C - A) * (D - B);
            int second = (G - E) * (H - F);
            return first - CalculateRect(A, B, C, D, E, F, G, H) + second;
        }


        private int CalculateRect(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            int xa = 0, ya = 0, xb = 0, yb = 0;

            if (x3 < x2 && y3 < y2)
            {
                if (x3 > x1)
                {
                    xa = x3;

                    if (y4 >= y2)
                    {
                        ya = y2;
                    }
                    else
                    {
                        ya = y4;
                    }
                }
                else
                {
                    xa = x1;

                    if (y4 >= y2)
                    {
                        ya = y2;
                    }
                    else
                    {
                        ya = y4;
                    }
                }

                if (x4 > x2)
                {
                    xb = x2;

                    if (y3 > y1)
                    {
                        yb = y3;
                    }
                    else
                    {
                        yb = y1;
                    }
                }
                else
                {
                    xb = x4;

                    if (y3 > y1)
                    {
                        yb = y3;
                    }
                    else
                    {
                        yb = y1;
                    }
                }
            }


            if (xa < xb && ya > yb)
            {
                return (xb - xa) * (ya - yb);
            }

            return 0;
        }
    }
}
