using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the 1st no : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
           // Console.WriteLine("enter the 2nd no :");
            //double num2  = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"{num1} {num2}");
            Console.WriteLine("choose operatror : *, /,+,- ,sin ,cos,tan ,cosec , sec , cot , log sqrt , pow");
            
            string  op = Convert.ToString(Console.ReadLine());
            double result = 0;
            switch (op)
            {
                case "*":
                    Console.WriteLine("enter 2nd number : ");
                    double mulnum = Convert.ToDouble(Console.ReadLine());
                    result = num1 * mulnum;
                    break;
                case "/":
                     Console.WriteLine("enter 2nd number : ");
                     double divnum = Convert.ToDouble(Console.ReadLine());
                     if (divnum != 0)
                     { 
                         result = num1 / divnum;

                     }
                     else
                     {
                         Console.WriteLine("undivided");
                     }
                     break;
                 case "+":
                    Console.WriteLine("enter 2nd number : ");
                    double addnum = Convert.ToDouble(Console.ReadLine());
                    result = num1 + addnum;
                             break;
                 case "-":
                    Console.WriteLine("enter 2nd number : ");
                    double subnum = Convert.ToDouble(Console.ReadLine());  
                    result = num1 - subnum;
                     break;
                case "sin":
                   double degree = num1 * Math.PI / 180;  // if calcu in degree
                    result = Math.Sin(degree); 
                   // result = Math.Sin(num1); // for radian
                    break;
                case "cos":
                    double cosdeg = num1 * Math.PI / 180;  // if calcu in degree
                    result = Math.Cos(cosdeg);
                    //result = Math.Cos(num1);
                    break;
                case "tan":
                    double tandeg = num1 * Math.PI / 180;  // if calcu in degree
                    result = Math.Tan(tandeg);
                    //result = Math.Tan(num1);
                    break;
                case "cosec":
                    double cosedeg = num1 * Math.PI / 180;  // if calcu in degree
                    result = 1/Math.Sin(cosedeg);
                    //result = 1/Math.Sin(num1);
                    break;
                case "sec":
                    double secdeg = num1 * Math.PI / 180;  // if calcu in degree
                    result = 1/Math.Cos(secdeg);
                    //result =  1/Math.Cos(num1);
                    break;
                case "cot":
                    double cotdeg = num1 * Math.PI / 180;  // if calcu in degree
                    result = 1/Math.Tan(cotdeg);
                    //result = 1/Math.Tan(num1);
                    break;
                case "log":
                    result = Math.Log10(num1);
                    break;
                case "sqrt":
                    result = Math.Sqrt(num1);
                    break;
                case "pow":
                    Console.WriteLine("enter the power:  ");
                    double power = Convert.ToDouble(Console.ReadLine());
                    result = Math.Pow(num1, power);
                    break;
                case "e":
                    result = Math.Exp(num1);
                    break;
                case "fact":
                    
                    if (num1 >=0)
                    { 
                        double factres = 1;
                     
                        for (double i = 1; i >= num1;i++)
                        {
                            
                            factres *= i;
                            
                        }
                        result = factres;
                    }
                    break;
                default:
                    Console.WriteLine("non existing");
                    break;
            }
            Console.WriteLine("result = " + result);
            //Console.ReadLine();
        }
    }
}
