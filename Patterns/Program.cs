using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Viksh Sharma");
            //hollowSquare(6);
            //numberTriangle(6);
            //numberIncPyramid(6);
            //numberIncRevPyramid(6);
            //numberChangingPyramid(6);
            //zeroOneTriangle(6);
            //pascalsTriangle(6);
            //numberEquiTriangle(6);
            //trapezium(6);
            //hollowHourGlass(6);
            //hollowDiamondPyramid(6);
            //HollowTriangle(6);
            //HollowReverseTriangle(6);
            //palindromeTriangle(6);
            //mirrorImageTriangle(6);
            diamond(6);

        }

        static void hollowSquare(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }

        static void numberTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        static void numberIncPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void numberIncRevPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void numberChangingPyramid(int n)
        {
            int temp = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(temp);
                    temp++;
                }
                Console.WriteLine();
            }
        }

        static void zeroOneTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine();
            }
        }

        static void pascalsTriangle(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    int value = factorial(i) / (factorial(i - j) * factorial(j));
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }

            int factorial(int num)
            {
                if (num <= 1) return 1;
                else
                {
                    return num * factorial(num - 1);
                }
            }
        }

        static void numberEquiTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }

        static void trapezium(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= n; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        static void hollowHourGlass(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < n - i; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || j == n - i - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }

                Console.WriteLine();
            }

            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < n - i; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || j == n - i - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void hollowDiamondPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void HollowTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1 || i == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void HollowReverseTriangle(int n)
        {
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1 || i == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void palindromeTriangle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n - i - 1; k++)
                {
                    Console.Write("  ");
                }

                for (int j = i; j >= 0; j--)
                {
                    Console.Write((j + 1) + " ");
                }

                for (int l = 1; l <= i; l++)
                {
                    Console.Write((l + 1) + " ");
                }

                Console.WriteLine();
            }
        }

        static void mirrorImageTriangle(int n)
        {
            for (int i = 1; i < n; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }

                for (int j = i; j < n; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < n - 2; i++)
            {
                for (int k = n - 2 - i; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (int j = n - i - 2; j < n; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }

        static void diamond(int n)
        {

            for (int i = 0; i < n; i++)
            {
                for (int k = n - 1 - i; k > 0; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = n - 2; i >= 0; i--)
            {
                for (int k = n - 1 - i; k > 0; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
