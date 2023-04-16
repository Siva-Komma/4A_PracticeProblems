using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogDemo
{
    public class AddNumbers
    {
        Nlog nlog = new Nlog();

        public int Sum(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                nlog.LogDebug("Debug Successfull : Sum()");
                nlog.LogError("Expecting null values");
                nlog.LogWarning("The value provided is Zero");

            }
            int c = a + b;
            nlog.LogDebug("Debug Successfull : Sum()");
            nlog.LogInformation("Sum Method passed, Results" + c);
            return c;
        }

        public void arrayInfo()
        {
            int[] a = new int[5];
            int i, j, count = 0;
            Console.WriteLine("Elements");
            for(i=0;i<a.Length;i++)
            {
                Console.WriteLine("Enter Elements");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("array Elements");
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Elements" + a[i]); 
            }
            for (i = 0; i < a.Length; i++)
            {
                for(j=i+1;j<a.Length;j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        Console.WriteLine(a[i]);
                        break;
                    }
                }
            }
            Console.WriteLine("Number of Elements repeated" + count);
        }
        public void Startrectangle()
        {
            int len = 7, width = 7;
            for(int i=1;i<=width;i++)
            {
                for(int j=1;j<=len;j++)
                {
                    if(i==1 || i==width || j==1 || j==len)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("\n");
            }
        }
        public void SumofMatric()
        {
            int sum, row, col;
            Console.WriteLine("How many rows u want?");
            row=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many cols u want?");
            col=Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[row,col];

            for(int i=0;i<row;i++)
            {
                for (int j=0;j<col;j++)
                {
                    Console.WriteLine("Enter elements of matrix");
                    matrix[i,j]=Convert.ToInt32(Console.ReadLine()); 
                }
            }
            Console.WriteLine("Matrix :");
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    Console.Write(matrix[i,j]+"\t");
                }
                Console.WriteLine();
            }
            for(int i = 0; i < row; i++)
            {
                sum = 0;
                for(int j=0;j<col;j++)
                {
                    sum += matrix[i,j];
                }
                Console.WriteLine("sum of row [{0}]:{1}",(i+1),sum );
            }
        }
    }
}
