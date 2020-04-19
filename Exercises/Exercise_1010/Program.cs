﻿using System;

namespace Exercise_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question -https://www.urionlinejudge.com.br/judge/en/problems/view/1010
            //In this problem, the task is to read a code of a product 1, the number of units of product 1, the price for one unit of product 1, the code of a product 2, the number of units of product 2 and the price for one unit of product 2.After this, calculate and show the amount to be paid.
            //
            //Input
            //The input file contains two lines of data.In each line there will be 3 values: two integers and a floating value with 2 digits after the decimal point.
            //
            //Output
            //The output file must be a message like the following example where "Valor a pagar" means Value to Pay.Remember the space after ":" and after "R$" symbol.The value must be presented with 2 digits after the point.

            int code, code2, number, number2;
            double price, price2;
            string[] product = Console.ReadLine().Split(' ');
            code = int.Parse(product[0]);
            number = int.Parse(product[1]);
            price = double.Parse(product[2]);
            String[] product2 = Console.ReadLine().Split(' ');
            code2 = int.Parse(product2[0]);
            number2 = int.Parse(product2[1]);
            price2 = double.Parse(product2[2]);
            double result = number * price;
            double result2 = number2 * price2;
            double total = result + result2;
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2") );
        }
    }
}
