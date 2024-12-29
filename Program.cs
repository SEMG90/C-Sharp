using System.Diagnostics;
namespace ConsoleApp
{
    // Demo
    enum Gender { 
        Male, Female
    }
    enum Days {
        Saturday, Sunday, Monday, Tuesday, Wednesday, Thrusday, Friday
    }
    enum Grades {
        A, B, C, D, E, F
    }

    // Assignment
    #region Assignment
    #region Question 01
    enum WeekDays
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    #endregion

    #region Question 02
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    #endregion

    #region Question 04
    enum Colors
    {
        Red,
        Green,
        Blue
    }
    #endregion
    #endregion

    internal class Program
    {
        /*public static void DoSomeCode()
        {
            try
            {
                int X, Y, Z;
                X = Convert.ToInt32(Console.ReadLine());
                Y = Convert.ToInt32(Console.ReadLine());
                Z = X / Y;

                int[] Numbers = { 1, 2, 3 };
                Numbers[10] = 100;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }*/


        /*public static void DoSomeProtictiveCode() {
            
            int X, Y, Z;
            bool Flag;
            // X = int.Parse(Console.ReadLine()); // FormatException
            do {
                Flag = int.TryParse(Console.ReadLine(), out X);
            } while (!Flag);
            // Y = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Enter Second Number");
                Flag = int.TryParse(Console.ReadLine(), out Y);
            } while (!Flag || Y == 0);

            Z = X / Y; // DivideByZeroException

            int[] Numbers = { 1, 2, 3 };
            if (Numbers.Length < 10) {
                Numbers[10] = 100; // IndexOutOfRangeException
            }
        }*/

        static void Main(string[] args)
        {
            #region Exception Handling
            /*
            try
            {
                DoSomeProtictiveCode();
                //throw new Exception();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                // close - free - delete - dealocate unmanaged resources
                // open file
                // open connection database
                Console.WriteLine("Finally");

            }
            //DoSomeProtictiveCode();
            //throw new Exception();
            Console.WriteLine("After Try Catch");
            */
            #endregion

            #region Access Modifier
            //TypeA typeA = new TypeA();
            #endregion

            #region Enums
            #region Ex01
            // string Day = "Hamada";
            // Days Day = Days.Friday;
            /*
            Grades Grade = Grades.A;
            if (Grade == Grades.A)
            {
                Console.WriteLine(":)");
            }
            else {
                Console.WriteLine("(:");
            }
            */
            #endregion

            #region Ex02
            // Grades grade = (Grades)2; // Excplicit Casting
            // Console.WriteLine(grade); // C
            //Grades grade = (Grades)10; // Excplicit Casting

            //Console.WriteLine(grade); // 10
            #endregion

            #region Ex03
            //Grades grade = (Grades)Enum.Parse(typeof(Grades), Console.ReadLine());

            //Console.WriteLine(grade);
            #endregion

            #region Part 06 Struct
            Point P01;
            /*
            P01.X = 10;
            P01.Y = 20;
            Console.WriteLine(P01.X);
            Console.WriteLine(P01.Y);
            */

            P01 = new Point();
            #endregion
            #endregion

            #region Assignment
            #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion

            #region 2.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out Season season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                    default:
                        Console.WriteLine("Invalid season.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid season name.");
            }
            #endregion

            #region 3.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.

            #endregion

            #region 4.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            Console.WriteLine("Enter a color (Red, Green, Blue):");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out Colors color))
            {
                switch (color)
                {
                    case Colors.Red:
                    case Colors.Green:
                    case Colors.Blue:
                        Console.WriteLine($"{color} is a primary color.");
                        break;
                    default:
                        Console.WriteLine($"{color} is not a primary color.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid color name.");
            }
            #endregion

            #region 5.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            #endregion
            #endregion
        }
        enum Roles
        {
            Admin = 10, Viewer = 20, Editor = 30
        }




    }
}