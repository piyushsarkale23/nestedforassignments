using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedforr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*// outer for loop which can be used for no. rows
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++) // column
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.WriteLine("---------------");



            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++) // column
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
            Console.WriteLine("-----------------");



            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++) // column
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
            Console.WriteLine("------------------");

            

            for (int i = 1; i <=5 ; i++)
            {
                for (int j = 5; j >= i; j--) // column
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            */
            int k = 5;
            for(int i = 1;i<=5;i++)
            {
                if(k>=1)
                {
                    Console.WriteLine("*");
                    k--;
                }
                for(int j=5;j<=k;j++)
                {
                    Console.WriteLine("  ");
                }
            }

            }
        }
    }
