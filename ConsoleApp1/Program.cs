using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace ConsoleApp1
{
    class Program
    {

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {

            Console.WriteLine("Total Number: " + n);

            var uList = new ArrayList();
            var pairCounter = 0;
            foreach (int x in ar)
            {
                if (!uList.Contains(x))
                {
                    uList.Add(x);
                }
            }

            foreach (int y in uList)
            {
                var counter = 0;
                foreach (int x in ar)
                {
                    if (y == x)
                    {
                        counter++;
                    }
                }

                if (counter > 0)
                {
                    var pair = counter / 2;
                    pairCounter += pair;
                } 
            }
            
            Console.WriteLine("Total Pair = " + pairCounter);
            return pairCounter;

        }

        static void Main(string[] args)
        {

            
           // int n = Convert.ToInt32(Console.ReadLine());
           int n = 9;
           // int[] ar2 = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int[] ar = {10, 20, 20, 10, 10, 30, 50, 10, 20};

            int result = sockMerchant(n, ar);




        }
    }
}
