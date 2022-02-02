using System;
using System.Text;

namespace _2.EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb= new StringBuilder();
            int spaces = 0;
            int col = int.Parse(Console.ReadLine());
            for (int i = col; i >= 1; i--)
            {
                for (int a = 1; a < i; a++)
                {
                    sb.Append(a);
                }
                sb.Append(i);
                for (int a = i -1; a >= 1; a--)
                {
                    sb.Append(a);
                }
                spaces++;
                sb.AppendLine();
                for (int a = 1; a <= spaces; a++)
                {
                    sb.Append(" ");
                }
            }
            Console.WriteLine(sb);
        }
    }
}
