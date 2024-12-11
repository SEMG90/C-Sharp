namespace Session1
{
    internal class Program
    {
        // Demo
        // static int Sum (int x,int y)
        //{
            //return x - y;
        //}
        static void Main(string[] args)
        {
            // Demo
            #region Errors Type
            #region Syntax Error
            //console.WriteLine("Hello");
            //iint x;
            #endregion

            #region RunTime Error
            //int x = 5;
            //int y = 0;
            //Console.WriteLine(x/y);
            #endregion

            #region Logical Error
            //int a = 10;
            //int b = 5;
            //Console.WriteLine(Sum(a, b));
            #endregion

            #region Warning Error
            //int x = 5; // 4 Byte
            //Console.WriteLine(x);
            #endregion
            #endregion

            #region Variables
            int number = 5;
            #endregion

            #region CTS - CLS
            //int x = 5; // 4 Bype

            //string Name = "Test"; // 8 Byte
            //Name = "Ali"; // 6 Byte
            #endregion

            #region Value Type
            //int x; // 4 Byte
            //Console.WriteLine(x);
            //x = 4;
            //int y = 9;
            //y = x;
            //x++;
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            #endregion

            #region Reference Type
            //Point P1;
            //P1 = new Point();

            //Point P2 = new Point();

            //P2 = P1;

            //P1.x = 10;
            //Console.WriteLine(P2.x);
            #endregion

            #region Object
            object obj1 = new object();
            object obj2 = new object();

            // obj = 1
            // obj = "Hello";
            // obj = 'A';
            // obj = true;

            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            obj2 = obj1;

            Console.WriteLine("***************************************************");
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
            #endregion

            #region Fractions & Discard
            //int num1 = 12344444444;
            long num2 = 12344444444;

            double num3 = 22.2;
            float num4 = 22.2f;
            decimal num5 = 2.22m;

            int num6 = 1_000_000_000;
            Console.WriteLine(num6);
            #endregion

            // Assignment
            #region 1.Write a program that allows the user to enter a number then print it.
            int n = 10;
            Console.WriteLine(n);
            #endregion

            #region 2.Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int n1 = 20; // Declare and initialize a value type variable
            int n2 = n1; // Assign the value of the first variable to a another variable
            n1 = 10;     // Modify the value of the first variable
            Console.WriteLine(n2); // Print second variable after modification
            #endregion

            #region 3.Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            Point Po1 = new Point(); // Declare a reference type variable and inherited of object
            Point Po2 = new Point(); // Declare a reference type variable and inherited of object
            Po2 = Po1; // Assign the value of the first variable to a another variable
            Po1.x = 50; // Modify the object of the first variable of class point
            Console.WriteLine(Po2.x); // Print second variable after modification
            #endregion
        }

    }
}