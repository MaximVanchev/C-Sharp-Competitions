using System;
using System.Linq;
using System.Text;

namespace _4._Easter_Surprise
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] boxesPlateSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] boxes = new char[boxesPlateSize[0], boxesPlateSize[1]];
            for (int row = 0; row < boxesPlateSize[0]; row++)
            {
                char[] boxesRow = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < boxesPlateSize[1]; col++)
                {
                    boxes[row, col] = boxesRow[col];
                }
            }
            int currentDigit = 0;
            char foundChar = char.Parse(Console.ReadLine());
            int[] Cordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] reserveCordinates = Cordinates.ToList().ToArray();
            char eddChar = boxes[Cordinates[0], Cordinates[1]];
            boxes[Cordinates[0], Cordinates[1]] = foundChar;
            for (int i = 0; i < boxesPlateSize[0] * boxesPlateSize[1] * 2; i++)
            {
                try
                {
                    if (boxes[Cordinates[0] + 1, Cordinates[1]] == eddChar)
                    {
                        Cordinates[0] += 1;
                        boxes[Cordinates[0], Cordinates[1]] = foundChar;
                        continue;
                    }
                }
                catch (Exception)
                {
                }
                try
                {
                    if (boxes[Cordinates[0] - 1, Cordinates[1]] == eddChar)
                    {
                        Cordinates[0] -= 1;
                        boxes[Cordinates[0], Cordinates[1]] = foundChar;
                        continue;
                    }
                }
                catch (Exception)
                {
                }
                try
                {
                    if (boxes[Cordinates[0], Cordinates[1] + 1] == eddChar)
                    {
                        Cordinates[1] += 1;
                        boxes[Cordinates[0], Cordinates[1]] = foundChar;
                        continue;
                    }
                }
                catch (Exception)
                {
                }
                try
                {
                    if (boxes[Cordinates[0], Cordinates[1] - 1] == eddChar)
                    {
                        Cordinates[1] -= 1;
                        boxes[Cordinates[0], Cordinates[1]] = foundChar;
                        continue;
                    }
                }
                catch (Exception)
                {
                }
                Cordinates = reserveCordinates;
                currentDigit++;
                if (currentDigit == 5)
                {
                    break;
                }
            }
            for (int i = 0; i < boxesPlateSize[0] * boxesPlateSize[1] * 2; i++)
            {
                try
                {
                    if (boxes[Cordinates[0], Cordinates[1] + 1] == eddChar)
                    {
                        Cordinates[1] += 1;
                        boxes[Cordinates[0], Cordinates[1]] = foundChar;
                        continue;
                    }
                }
                catch (Exception)
                {
                }
                try
                {
                    if (boxes[Cordinates[0], Cordinates[1] - 1] == eddChar)
                    {
                        Cordinates[1] -= 1;
                        boxes[Cordinates[0], Cordinates[1]] = foundChar;
                        continue;
                    }
                }
                catch (Exception)
                {
                }
                try
                {
                    if (boxes[Cordinates[0] + 1, Cordinates[1]] == eddChar)
                    {
                        Cordinates[0] += 1;
                        boxes[Cordinates[0], Cordinates[1]] = foundChar;
                        continue;
                    }
                }
                catch (Exception)
                {
                }
                try
                {
                    if (boxes[Cordinates[0] - 1, Cordinates[1]] == eddChar)
                    {
                        Cordinates[0] -= 1;
                        boxes[Cordinates[0], Cordinates[1]] = foundChar;
                        continue;
                    }
                }
                catch (Exception)
                {
                }
                Cordinates = reserveCordinates;
                currentDigit++;
                if (currentDigit == 5)
                {
                    break;
                }

                for (int i = 0; i < boxesPlateSize[0] * boxesPlateSize[1] * 2; i++)
                {
                    try
                    {
                        if (boxes[Cordinates[0], Cordinates[1] - 1] == eddChar)
                        {
                            Cordinates[1] -= 1;
                            boxes[Cordinates[0], Cordinates[1]] = foundChar;
                            continue;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        if (boxes[Cordinates[0], Cordinates[1] + 1] == eddChar)
                        {
                            Cordinates[1] += 1;
                            boxes[Cordinates[0], Cordinates[1]] = foundChar;
                            continue;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        if (boxes[Cordinates[0] - 1, Cordinates[1]] == eddChar)
                        {
                            Cordinates[0] -= 1;
                            boxes[Cordinates[0], Cordinates[1]] = foundChar;
                            continue;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        if (boxes[Cordinates[0] + 1, Cordinates[1]] == eddChar)
                        {
                            Cordinates[0] += 1;
                            boxes[Cordinates[0], Cordinates[1]] = foundChar;
                            continue;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    
                    Cordinates = reserveCordinates;
                    currentDigit++;
                    if (currentDigit == 5)
                    {
                        break;
                    }
                }
            }
                Console.WriteLine(MatrixToString(boxes, boxesPlateSize));
        }
        public static string MatrixToString(char[,] matrix, int[] size)
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < size[0]; row++)
            {
                for (int col = 0; col < size[1]; col++)
                {
                    sb.Append(matrix[row, col]);
                }
                sb.AppendLine();
            }
            return sb.ToString().TrimEnd();
        }
    }
}
