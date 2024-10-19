// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

using System;
using System.Xml.XPath;

class program 
{
    static void Main ()
    {

        Console.Write("enter the first number!");
        double num1 =Convert.ToDouble(Console.ReadLine());//just a question, why double not int?//
        Console.Write("enter the secound number!");
        double num2 =Convert.ToDouble(Console.ReadLine());
        Console.Write("enter the opreator symbol!(+,-,*,/):");
        char oper = Convert.ToChar(Console.ReadLine());
        double result =0;
        if(oper=='+')

        {
            result =num1 + num2;
        }
        else if (oper=='-')
        {
            result= num1- num2;
        }
        else if (oper=='*')
        {
            result=num1*num2;
        }
        else if (oper=='/')
        {
            result=num1/num2;
        }
        Console.WriteLine("the result is:"+ result); //drumps for the final result to make math more likeable:) //
    } 
}