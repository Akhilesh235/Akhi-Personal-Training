using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akhi_Personal_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take a number as input and display it four times in a row with spaces and then without spaces
            
            int x;
            Console.WriteLine("Enter a digit : ");
            x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n{0} {0} {0} {0} ", x);

            Console.WriteLine("{0}{0}{0}{0} ", x);



            ////Input Age and see whether Child, Adult or Senior Citizen

            //int x;
            //Console.WriteLine("Input your age: ");
            //x = Int32.Parse(Console.ReadLine());

            //if (x >= 60)
            //{
            //    Console.WriteLine("You are senior citizen");
            //}

            //else if (x >= 21)
            //{
            //    Console.WriteLine("You are an adult");
            //}

            //else if (x < 21)
            //{
            //    Console.WriteLine("You are a child");
            //} 





            //three numbers(x, y, z) as input and print the output of(x + y).z and x.y + y.z


            //int num1, num2, num3;
            //int sum;
            //int sum2;
            //int multiply;
            //int multiply2;
            //int multiply3;

            //Console.WriteLine("\nInput x: ");
            //num1 = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("\nInput y: ");
            //num2 = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("\nInput z: ");
            //num3 = Int32.Parse(Console.ReadLine());

            //sum = num1 + num2;
            //multiply = sum * num3;


            //multiply2 = num1 * num2;
            //multiply3 = num2 * num3;
            //sum2 = multiply2 + multiply3;

            //Console.WriteLine("\nThe result of (x+y).z is : {0} \n\nThe result of (x.y) + (y.z) is : {1} " , multiply, sum2 );





            ////Input 4 numbers and find average

            //double num1, num2, num3, num4;
            //double sum;
            //double average;

            //Console.WriteLine("Input First number");
            //num1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("\nInput Second number");
            //num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("\nInput Third number");
            //num3 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("\nInput Fourth number");
            //num4 = Convert.ToDouble(Console.ReadLine());

            //sum = num1 + num2 + num3 + num4;
            //average = sum / 4;

            //Console.WriteLine("\nAverage of these 4 numbers are: " + average);





            ////Multiplication Table

            //int x;
            //int result;

            //Console.WriteLine("Enter a number: ");
            //x = Int32.Parse(Console.ReadLine());

            //result = x * 1;
            //Console.WriteLine("The table for the number {0} is : {0} x {1} = {2}" , x, 1, result);

            //result = x * 2;
            //Console.WriteLine("                              : {0} x {1} = {2}", x, 2, result);

            //result = x * 3;
            //Console.WriteLine("                              : {0} x {1} = {2}", x, 3, result);

            //result = x * 4;
            //Console.WriteLine("                              : {0} x {1} = {2}", x, 4, result);

            //result = x * 5;
            //Console.WriteLine("                              : {0} x {1} = {2}", x, 5, result);


            //result = x * 6;
            //Console.WriteLine("                              : {0} x {1} = {2}", x, 6, result);

            //result = x * 7;
            //Console.WriteLine("                              : {0} x {1} = {2}", x, 7, result);

            //result = x * 8;
            //Console.WriteLine("                              : {0} x {1} = {2}", x, 8, result);


            //result = x * 9;
            //Console.WriteLine("                              : {0} x {1} = {2}", x, 9, result);

            //result = x * 10;
            //Console.WriteLine("                              : {0} x {1} = {2}", x, 10, result);


            // int num1, num2;

            //Console.WriteLine("\nInput the first number : ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("\nInput the second number : ");
            //num2 = int.Parse(Console.ReadLine());

            ////1 Add
            //int sum = num1 + num2;
            //Console.WriteLine("Sum of both numbers is: " + sum);

            ////2 subtract
            //int sub = num1 - num2;
            //Console.WriteLine("Subratction of both numbers is: " + sub);

            ////multiply
            //int multiply = num1 * num2;
            //Console.WriteLine("Multiplication of both numbers is: " + multiply);

            ////Division
            //int divide = num1 / num2;
            //int remainder = num1 % num2;
            //Console.WriteLine("Division of both numbers is: " + divide + "\nWith a remainder of: " + remainder);







            //int number1, number2, number3;

            //Console.WriteLine("\n input first number");
            //number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("\n input second number");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("\n input third number");
            //number3 = int.Parse(Console.ReadLine());


            //int result = number1 * number2 * number3;
            //Console.WriteLine("the result is : " + result);



            //int i, j, temp;

            //Console.WriteLine("\nInput first number");
            //i = int.Parse(Console.ReadLine());

            //Console.WriteLine("\nInput second number");
            //j = int.Parse(Console.ReadLine());

            //temp = i;
            //i = j;
            //j = temp;
            //Console.WriteLine("\nAfter Swapping");
            //Console.WriteLine("\n first number: " + i);
            //Console.WriteLine("\n second number: " + j);


            //int i = 10, j = 20;

            //if (i>j)
            //{
            //    Console.WriteLine("i greater than j");
            //}

            //if (i < j)
            //{
            //    Console.WriteLine("i smaller than j");
            //}

            //if (i == j)
            //{
            //    Console.WriteLine("i equal to j");
            //}
            //Coordinate point = new Coordinate(10, 20);

            ////point.x = 10;
            ////point.y = 20;
            ////Coordinate point = new Coordinate();

            //Console.WriteLine("x: " + point.x);
            //Console.WriteLine("y: " + point.y);



            //string firstName = "James";
            //string lastName = "Bond";
            //string code = "007";

            //string fullName = $"{firstName} {lastName}, Code: {code}";

            //Console.WriteLine(fullName);

            //string str = @"this is a 
            //                multi line 
            //                string";
            //Console.WriteLine(str);


            //string text = "this is a \"string\" in c#";
            //Console.WriteLine(text);




            //char[] chars = { 'H', 'E', 'L', 'L', 'O' };

            //Console.WriteLine(chars);

            //string str1 = new string(chars);
            //String str2 = new String(chars);

            //foreach (char c in str1)
            //{
            //    Console.WriteLine(c);
            //}



            //foreach (char c in str2)
            //{
            //    Console.WriteLine("\n" + c);
            //}

            //var i = 10;
            //Console.WriteLine("Type of i is {0}", i.GetType());

            //var str = "Akhilesh";
            //Console.WriteLine("Type of str is {0}", str.GetType());

            //var dbl = 10.2;
            //Console.WriteLine("type of dbl is {0}", dbl.GetType());

            //var isValid = true;
            //Console.WriteLine("type of isValid is {0}", isValid.GetType());

            //Array arr = new[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine("type of arr is {0}", arr.GetType());



            //int i = 1;
            //int j = ++i;
            //int k = --j;


            //Console.WriteLine(k);



            //int i = 100,
            //    j = 10,
            //    k = 4;





            //int i = 100, j = 10, k = 77;
            //Console.WriteLine("the value of i : " + i);
            //Console.WriteLine("the value of j : " + j);
            //Console.WriteLine("the value of k : " + k);


            //int num = 100;
            //float rate = 10.2f;
            //double amount = 100.5;
            //char code = 'C';
            //bool isValid = true;
            //string name = "Steve";

            //Console.WriteLine(num + "\n");
            //Console.WriteLine(rate);
            //Console.WriteLine(amount);
            //Console.WriteLine(code);
            //Console.WriteLine(isValid);
            //Console.WriteLine(name);

            //Console.ReadLine();

            //string message = "Hello World!";

            //Console.WriteLine(message);
            Console.Read();
        }
    }
}
