using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demo
            #region Value Types Casting
            #region Implicit Casting
            //int x = 4; // bytes
            //long y = /*(long)*/ x;
            #endregion

            #region Explicit Casting - unSafe Casting
            /*long x = 1010101010; // 8 bytes

            int y;
            checked
            {
                y = (int)x; 
            }
            Console.WriteLine(y);*/

            //int x = 88;
            //double y = /*(double)*/ x;

            //double x = 88.8;
            //int y = (int)x;
            //Console.WriteLine(y);
            #endregion

            #region Parse Casting [convert from string to any data type]
            //int number = int.Parse(Console.ReadLine());
            /*
            Console.WriteLine("Enter Data User");

            Console.Write("Enter your Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter your Age : ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter your Salary : ");
            double salary = double.Parse(Console.ReadLine());


            Console.WriteLine("Name : " + name + ", Age : " + age + ", Salary : " + salary);  
            */
            #endregion

            #region Convert Casting [convert from any data type to any data type]
            /*Console.WriteLine("Enter Data User");

            Console.Write("Enter your Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Salary : ");
            double salary = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Name : " + name + ", Age : " + age + ", Salary : " + salary);*/
            #endregion
            #endregion

            #region Operators
            #region Unary Operators [++, --]
            int x = 5;
            //x++;
            //++x;
            //Console.WriteLine(++x);
            //Console.WriteLine(x);

            //Console.WriteLine(--x);
            //Console.WriteLine(x--);
            //Console.WriteLine(x);
            #endregion
            #endregion

            #region Binary Operators
            /*int sum, mul, sub, div, mod;

            int a = 8;
            int b = 5;

            sum = a + b;
            sub = a - b;
            mod = a % b;
            div = a / b;
            mul = a * b;
            Console.WriteLine(mul);*/
            #endregion

            #region Assignment Operators
            /*int x = 10;

            x += 10; // x = x + 10 
            x -= 10;
            x *= 10;
            x /= 10;
            x %= 10;*/
            #endregion

            #region Relational Operators
            /*int a = 5;
            int b = 5;

            Console.WriteLine(a < b);*/
            #endregion

            #region Logical Operator [Short Circut]
            //Console.WriteLine(!true);

            //Console.WriteLine(true && false);
            // true && true = true
            // true && false = false
            // false && true = false
            // false && false = false

            //nsole.WriteLine(true || false);
            // true || true = true
            // true || false = true
            // false ||true = true
            // false ||false = false
            #endregion

            #region Bitwise Operators [Long Circut]
            //Console.WriteLine(true && false);
            // true && true = true
            // true && false = false
            // false && true = false
            // false && false = false

            //nsole.WriteLine(true || false);
            // true || true = true
            // true || false = true
            // false ||true = true
            // false ||false = false
            #endregion

            #region Ternary Operators [Conditional Operator]
            /* int z = 4;
            string message = z > 4 ? "x Greater than 4" : "x less than or equal 4";
            Console.WriteLine(message);*/
            #endregion

            #region Operator Periorety
            /*
             * Unary => Prefix 
             * ()
             * * / % 
             * + -
             */
            /*
            int a = 20;
            int b = 15;
            int c = 10;
            int d = 5;

            int result;

            result = (a + b) * c / d;
            Console.WriteLine(result);*/
            #endregion

            #region String Formatting
            // Equation = x + y = Result
            // Equation = 10 + 5 = 15
            //int x = 5;
            //int y = 10;
            //int Result = x + y;

            //Console.WriteLine("Equation : " + x + " + " + y + " = " + Result);
            // string => immutable datatype
            // string name = "Ahmed";
            // name = "Ali";

            #region 1.Composite format
            //string message = string.Format("Equation = {0} + {1} = {2}", x, y, Result);
            //Console.WriteLine(message);
            //Console.ReadLine("Equation = {0} + {1} = {2}", x, y, Result);
            #endregion

            #region 2.String Manipolition
            // string interpolation => $
            //Console.WriteLine($"Equation = {x} + {y} = {Result}");
            #endregion

            #endregion

            #region IF Else - Switch Case
            //Console.WriteLine("Enter Month Number");
            //int MonthNumber = int.Parse(Console.ReadLine());
            // 1 => Month is Jan
            // 2 => Month is Feb
            // 3=> Month is Mar
            // Invalid Input

            /*
            if(MonthNumber == 1)
                { Console.WriteLine("Month is Jan"); }
            else if(MonthNumber == 2)
                { Console.WriteLine("Month is Feb"); }
            else if(MonthNumber == 3)
                { Console.WriteLine("Month is Mar"); }
            else
                { Console.WriteLine("Invalid Input"); }
            */

            /*
            switch (MonthNumber)
            {
                case 1:
                    Console.WriteLine("Month is Jan");
                    break;
                case 2:
                    Console.WriteLine("Month is Feb");
                    break;
                case 3:
                    Console.WriteLine("Month is Mar");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            */

            //Console.WriteLine("Enter Name : ");
            //string name = Console.ReadLine();

            /*
            if (name == "Mostafa")
            { Console.WriteLine("Hello Mostafa"); }
            else if (name == "Aliaa")
            { Console.WriteLine("Hello Aliaa"); }
            else if (name == "Ahmed")
            { Console.WriteLine("Hello Ahmed"); }
            */
            /*
            switch (name)
            {
                case "Mostafa":
                    Console.WriteLine("Hello Mostafa");
                    break;

                case "Aliaa":
                    Console.WriteLine("Hello Aliaa");
                    break;

                case "Ahmed":
                    Console.WriteLine("Hello Ahmed");
                    break;
            }     
            */
            #endregion

            #region GoTo
            Console.WriteLine("Enter Option");
            // 3000 => "Option 01", "Option 02", "Option 03"
            // 2000 => "Option 01", "Option 02"
            // 1000 => "Option 01"

            /*
            int Option = int.Parse(Console.ReadLine());

            switch (Option) {
                case 3000:
                    Console.WriteLine("Option 03");
                    goto case 2000;
                case 2000:
                    Console.WriteLine("Option 02");
                    goto case 1000;
                case 1000:
                    Console.WriteLine("Option 01");
                    break;
            }
            */
            #endregion

            #region Evaluation of Switch Case
            Console.WriteLine("Enter Age");
            int age = int.Parse(Console.ReadLine());
            switch (age)
            {
                case > 22:
                    Console.WriteLine("age greater than 22");
                    break;
                case < 22:
                    Console.WriteLine("age less than 22");
                    break;
                default:
                    Console.WriteLine("age equal 22");
                    break;
            }
            #endregion

            #region Assignment 03

            #region 1.Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            Console.WriteLine("Enter User Number : ");
            int num = int.Parse(Console.ReadLine());
            if(num % 3 == 0 && num % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            #endregion

            #region 2.Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            Console.WriteLine("Enter Integer Number : ");
            int number = int.Parse(Console.ReadLine());

            if(number < 0)
            {
                Console.WriteLine("Negative Number");
            }
            else if(number > 0)
            {
                Console.WriteLine("Positive Number");
            }

            #endregion

            #region 3.Write a program that takes 3 integers from the user then prints the max element and the min element.
            Console.WriteLine("Enter Number 1 : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 2 : ");
            int num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Number 3 : ");
            int num3 = int.Parse(Console.ReadLine());
                
            int maxNum = Math.Max(num1, Math.Max(num2, num3));
            int minNum = Math.Min(num1, Math.Min(num2, num3));

            Console.WriteLine($"Max Number = {maxNum} , Min Number = {minNum}");
            #endregion

            #region 4.Write a program that allows the user to insert an integer number then check If a number is even or odd.
            Console.Write("Enter an integer : ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            #endregion

            #region 5.Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            Console.Write("Enter a character: ");
            char input = char.Parse(Console.ReadLine().ToLower());

            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
            #endregion

            #region 6.Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            Console.Write("Enter an integer: ");
            int numb = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication table for {numb}:");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{numb} x {i} = {numb * i}");
            }
            #endregion

            #region 7.Write a program that takes two integers then prints the power.
            Console.Write("Enter the base number: ");
            int baseNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the exponent: ");
            int exponent = int.Parse(Console.ReadLine());

            double result = Math.Pow(baseNumber, exponent);
            Console.WriteLine($"{baseNumber} raised to the power of {exponent} is {result}");
            #endregion

            #region 8.Write a program to enter marks of five subjects and calculate total, average and percentage.
            Console.WriteLine("Enter Mark 1 : ");
            int sub1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Mark 2 : ");
            int sub2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Mark 3 : ");
            int sub3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Mark 4 : ");
            int sub4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Mark 5 : ");
            int sub5 = int.Parse(Console.ReadLine());

            int total = sub1+sub2+sub3+sub4+sub5;
            int avg = total / 5;
            double per = total * 0.100;
            #endregion

            #region 9.Write a program to input the month number and print the number of days in that month.
            Console.Write("Enter the month number : ");
            int month = int.Parse(Console.ReadLine());

            int days;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 2:
                    Console.Write("Enter the year: ");
                    int year = int.Parse(Console.ReadLine());
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                        days = 29;
                    else
                        days = 28;
                    break;
                default:
                    Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
                    return;
            }

            // Print the number of days
            Console.WriteLine($"The month {month} has {days} days.");
            #endregion

            #region 10.Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            Console.Write("Enter the x1 coordinate: ");
            int x1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the y1 coordinate: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the x2 coordinate: ");
            int x2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the y2 coordinate: ");
            int y2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the x3 coordinate: ");
            int x3 = int.Parse(Console.ReadLine());

            Console.Write("Enter the y3 coordinate: ");
            int y3 = int.Parse(Console.ReadLine());

            if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            {
                Console.WriteLine("The points lie on the same straight line.");
            }
            else
            {
                Console.WriteLine("The points do not lie on the same straight line.");
            }
            #endregion

            #region 11.Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
                    -If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
                    -If the worker takes 3 to 4 hours, they are instructed to increase their speed.
                    -If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
                    -If the worker takes more than 5 hours, they are required to leave the company.
                      To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

            Console.Write("Enter the time taken to complete the task (in hours): ");
            double timeTaken = double.Parse(Console.ReadLine());

            if (timeTaken >= 2 && timeTaken <= 3)
            {
                Console.WriteLine("Highly Efficient");
            }
            else if (timeTaken > 3 && timeTaken <= 4)
            {
                Console.WriteLine("Increase Speed");
            }
            else if (timeTaken > 4 && timeTaken <= 5)
            {
                Console.WriteLine("Provide Training");
            }
            else if (timeTaken > 5)
            {
                Console.WriteLine("Required to Leave the Company");
            }
            else
            {
                Console.WriteLine("Invalid input. Time taken cannot be less than 2 hours.");
            }
            #endregion

            #region 12.Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int number1 = 10;
            int number2 = number1;  

            number2 = 20;
            Console.WriteLine("Value of num1: " + number1);  
            Console.WriteLine("Value of num2: " + number2);
            #endregion

            #region 13.Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            Person person1 = new Person();
            person1.Name = "Alice";
            Person person2 = person1;
            person2.Name = "Bob";
            Console.WriteLine("Name of person1: " + person1.Name); 
            Console.WriteLine("Name of person2: " + person2.Name);
            #endregion

            #region 14.Which of the following statements is correct about the C#.NET code snippet given below?
            // choose => d)The code reports an error.
            #endregion

            #region 15.Which of the following is the correct output for the C# code given below?
            // choose => d)6 1
            #endregion

            #region 16.What will be the output of the C# code given below?
            // choose => d)7 7
            #endregion

            #endregion


        }
    }
}
