using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task 1: Remove the comment marks and fix this code. Explain changes as comments*/
            float i = 10.8f; // if float variable must have f behind number 
            int k = 100 + (int)i; // float is stronger than int, we should convert float to int
            string myStr = Convert.ToString(i + k); // Convert.ToString
            int j = (int)i + k; // same explain above
            Console.WriteLine("i + k = " + myStr + ", j = " + j);

            /*Task 2:
             Primarily applying the direct casting, if it does not work then explicit type casting, 
             then with some other method convert the given number to different types, 
             if any of them is possible.
            */

            //For each case:
            //If type can be converted, remove the comments from the variable declaration 
            //and IF NECESSARY, ADD the conversion with suitable method
            //Next remove the comments from the output case that describes your selection

            //    byte myByte = 293.34;
            Console.Write("Number constant 293.34 converts in type byte as ");
            //Console.WriteLine(myByte + " without explicit casting");
            //Console.WriteLine(myByte + " with explicit casting and without loss of data");
            //Console.WriteLine(myByte + " with explicit casting but with loss of data");
            //Console.WriteLine(myByte + " not with explicit casting, but with Convert -object");
            Console.WriteLine("with no methods");

            int myInt = (int)293.34;
            Console.Write("Number constant 293.34 converts in type int as ");
            //Console.WriteLine(myInt + " without explicit casting");
            //Console.WriteLine(myInt + " with explicit casting and without loss of data");
            Console.WriteLine(myInt + " with explicit casting but with loss of data");
            //Console.WriteLine(myInt + " not with explicit casting, but with Convert -object");
            //Console.WriteLine("with no methods");

            float myFloat = (float)293.34;
            Console.Write("Number constant 293.34 converts in type float as ");
            //Console.WriteLine(myFloat + " without explicit casting");
            Console.WriteLine(myFloat + " with explicit casting and without loss of data");
            //Console.WriteLine(myFloat + " with explicit casting but with loss of data");
            //Console.WriteLine(myFloat + " not with explicit casting, but with Convert -object");
            //Console.WriteLine("with no methods");

            double myDouble = 293.34;
            Console.Write("Number constant 293.34 converts in type double as ");
            Console.WriteLine(myDouble + " without explicit casting");
            //Console.WriteLine(myDouble + " with explicit casting and without loss of data");
            //Console.WriteLine(myDouble +  "with explicit casting but with loss of data");
            //Console.WriteLine(myDouble + " not with explicit casting, but with Convert -object");
            //Console.WriteLine("with no methods");

            decimal myDecimal = (decimal)293.34;
            Console.Write("Number constant 293.34 converts in type decimal as ");
            //Console.WriteLine(myDecimal + " without explicit casting");
            Console.WriteLine(myDecimal + " with explicit casting and without loss of data");
            //Console.WriteLine(myDecimal +  "with explicit casting but with loss of data");
            //Console.WriteLine(myDecimal + " not with explicit casting, but with Convert -object");
            //Console.WriteLine("with no methods");

            //bool myBoolean = 293.34;
            Console.Write("Number constant 293.34 converts in type boolean as ");
            //Console.WriteLine(myBoolean + " without explicit casting");
            //Console.WriteLine(myBoolean + " with explicit casting and without loss of data");
            //Console.WriteLine(myBoolean + " with explicit casting but with loss of data");
            //Console.WriteLine(myBoolean + " not with explicit casting, but with Convert -object");
            Console.WriteLine("with no methods");

            string myString = Convert.ToString(293.34);
            Console.Write("Number constant 293.34 converts in type string as ");
            //Console.WriteLine(myString + " without explicit casting");
            //Console.WriteLine(myString + " with explicit casting and without loss of data");
            //Console.WriteLine(myString + " with explicit casting but with loss of data");
            Console.WriteLine(myString + " not with explicit casting, but with Convert -object");
            //Console.WriteLine("with no methods");         



            /*Task 3:
         *    Convert, if possible, with some method, the text constant "293,34" such that the value can be assigned to a
         *    variable of different types 
         *    Add conversion and remove comments if the conversion is possible 
         *   Remove also comments from those output commands that are feasible
             */
            string origNr = "293,34";
            //byte byteNr = origNr;
            //int intNr = origNr;
            float floatNr = Convert.ToSingle(origNr);
            double doubleNr = Convert.ToDouble(origNr);
            decimal decimalNr = Convert.ToDecimal(origNr);
            //boolean booleanNr = origNr;
            string stringNr = origNr;
            //Console.WriteLine("Byte type is ok: " + byteNr);
            Console.WriteLine("Byte type is NOT ok");
            //Console.WriteLine("Int type is ok: " + intNr);
            Console.WriteLine("Int type is NOT ok");
            Console.WriteLine("Float type is ok: " + floatNr);
            //Console.WriteLine("Float type is NOT ok");
            Console.WriteLine("Double type is ok: " + doubleNr);
            //Console.WriteLine("Double type is NOT ok");
            Console.WriteLine("Decimal type is ok: " + decimalNr);
            //Console.WriteLine("Decimal type is NOT ok");
            //Console.WriteLine("Boolean type is ok: " + booleanNr);
            Console.WriteLine("Boolean type is NOT ok");
            Console.WriteLine("String type is ok: " + stringNr);
            //Console.WriteLine("String type is NOT ok");




            /*Task 4:
             Create a program which is able to convert temperature given in Celsius –degrees to Fahrenheit
             degrees. Test your algorithm with all values Celsius = 0.0, Celsius = 100.0 and Celsius = 37,3 and output the result 
             in format
                         xx degrees in Celsius correspond to yy degrees in Fahrenheit
            */
            double f;
            double c = 0.0;

            f = c * 9 / 5 + 32;
            Console.WriteLine($"{c} degrees in Celsius correspond to {f} degrees in Fahrenheit");

            c = 100.0;
            f = c * 9 / 5 + 32;
            Console.WriteLine($"{c} degrees in Celsius correspond to {f} degrees in Fahrenheit");

            c = 37.3;
            f = c * 9 / 5 + 32;
            Console.WriteLine($"{c} degrees in Celsius correspond to {f} degrees in Fahrenheit");

            /*Task 5
              Create a program which is able to calculate the value of the given expression
              with values (x,y,z,w) = (1,1,1,0) and (x,y,z,w) = (11,11,11,11) and output the results in format

                  f(x,y,z,w) = xxx

             */
            int x, y, z, w;
            double res;

            x = 1;
            y = 1;
            z = 1;
            w = 0;
            res = (double)(10 + x) / (9 * x + 2) - (double)4 * (x / y) + (double)(z * 3 + w) / ((z / x) + y);
            Console.WriteLine($"f({x},{y},{z},{w}) = {res}");

            x = 11;
            y = 11;
            z = 11;
            w = 11;
            res = (double)(10 + x) / (9 * x + 2) - (double)4 * (x / y) + (double)(z * 3 + w) / ((z / x) + y);
            Console.WriteLine($"f({x},{y},{z},{w}) = {res}");
        }
    }
}