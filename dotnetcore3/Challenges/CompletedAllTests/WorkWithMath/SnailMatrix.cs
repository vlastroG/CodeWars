using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace dotnetcore3.Challenges.CompletedAllTests.WorkWithMath
{
    internal class SnailMatrix
    {
        public static int[] Snail(int[][] array)
        {
            if (array == null) return new int[0];
            if (array.Length == 0) return new int[0];
            if (array[0].Length == 0) return new int[0];

            var num = 1;
            var circle = 0; // number of snake's loop starts from zero
            var width = array.Length;
            var height = array[0].Length;
            var count = width * height;
            List<int> numbers = new List<int>();
            bool makeWork = true;
            while (makeWork)
            {
                for (int j = circle; j < width - circle; j++) //get top row left to right
                {
                    numbers.Add(array[circle][j]);
                    num++;
                    makeWork = !(num > count);
                }

                for (int i = circle + 1; i < height - circle; i++) //get right column top to bottom
                {
                    numbers.Add(array[i][width - 1 - circle]);
                    num++;
                    makeWork = !(num > count);
                }

                for (int j = width - 2 - circle; j >= circle; j--) //get bottom row right to left
                {
                    numbers.Add(array[height - 1 - circle][j]);
                    num++;
                    makeWork = !(num > count);
                }

                for (int i = height - 2 - circle; i > circle; i--) //get left column bottom to top
                {
                    numbers.Add(array[i][circle]);
                    num++;
                    makeWork = !(num > count);
                }
                circle++;
            }
            return numbers.ToArray();
        }


        public static int[,] FillMatrix(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }
            var num = 1;
            var circle = 0;
            var width = matrix.GetLength(1);
            var height = matrix.GetLength(0);
            var count = width * height;

            //for (int i = 0 + circle; i < matrix.GetLength(0) - 2 * circle; i++)
            while (true)
            {
                for (int j = circle; j < width - circle; j++) //заполнение верхней строки
                {
                    matrix[circle, j] = num;
                    num++;
                    if (num > count)
                    {
                        return matrix;
                    }
                }

                for (int i = circle + 1; i < height - circle; i++) //заполнение правого столбца
                {
                    matrix[i, width - 1 - circle] = num;
                    num++;
                    if (num > count)
                    {
                        return matrix;
                    }
                }

                for (int j = width - 2 - circle; j >= circle; j--) //заполнение нижней строки
                {
                    matrix[height - 1 - circle, j] = num;
                    num++;
                    if (num > count)
                    {
                        return matrix;
                    }
                }

                for (int i = height - 2 - circle; i > circle; i--) //заполнение левого столбца
                {
                    matrix[i, circle] = num;
                    num++;
                    if (num > count)
                    {
                        return matrix;
                    }
                }
                circle++;
            }
        }
    }
}
