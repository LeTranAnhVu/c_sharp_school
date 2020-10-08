using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1: 1	Create a program which declares variables with suitable types ...

            //Copy your program code here and run the automatic assessment. Pay attention to the output, it must exactly match with model
            //Pay also attention to the variable types and the way of producing the output
            float carWeight = 2500f; // float because car weight can be decimal
            string carColour = "green"; // string because green is text
            int numOfPassengers = 5; // int because number of passengers is integer
            float lGasPerKm = 6.4f; // float because liters is decimal and not too big for double
            double disToSunByKm = 149021003.5; // double because it is big number

            Console.WriteLine("Car weight is " + carWeight + " kg");
            Console.WriteLine("Car colour is " + carColour);
            Console.WriteLine("There are " + numOfPassengers + " passengers");
            Console.WriteLine("One hundred km drive consumes " + lGasPerKm + " liters of gasoline per kilometer");
            Console.WriteLine("Distance to the sun is " + disToSunByKm + " kilometers");

            //Exercise 2: 2	Define applicable types and names for the variables ...
            //copy paste or directly write the solutions here, compile and run to verify it works. No automatic assessment, teacher will manually check the solutions
            //a)	Number of inhabitants in a country
            uint population = 5518000;
            Console.WriteLine("Finland population is " + population);

            population = 1393000000; // china population currently
            Console.WriteLine("China population is " + population);

            //b)	Student grade in scale A, B, C, D, E. A is the best, E is the worst grade.
            char grade = 'A';
            Console.WriteLine("Brian has a " + grade + " grade.");

            grade = 'E';
            Console.WriteLine("Anna has a " + grade + " grade.");
            //c)	Current lap of a Formula 1 car during the race
            int currentLap = 203;
            Console.WriteLine("Current lap is " + currentLap);
            currentLap++;
            Console.WriteLine("And the next lap is " + currentLap);

            //d)	Relative progress of file upload process	
            int uploadedPercent = 50;
            Console.WriteLine("the file is uploaded by " + uploadedPercent + "%");

            uploadedPercent = 100;
            Console.WriteLine("the file is uploaded by " + uploadedPercent + "%");
            //e)	Username in the system login
            string username = "vule";
            Console.WriteLine("Hello " + username + "!");
            username = "brianle";
            Console.WriteLine("Hi again Mr." + username + "!");
            //f)	Information if the login was succesful or not
            bool isLogin = false;
            Console.WriteLine("Your login is "+ isLogin);

            isLogin = true;
            Console.WriteLine("Your login is "+ isLogin);


            //g)	Days left before the next Olympic games
            int dayLeft = 300;
            Console.WriteLine("There are "+dayLeft+" day(s) left"); 

            dayLeft = 400;
            Console.WriteLine("There are "+dayLeft+" day(s) left"); 

            double price = 300.2;
            Console.WriteLine("this laptop's cost is " +price+ " euro(s)");

            price = 200;
            Console.WriteLine("this laptop's cost is " +price+ " euro(s)");
        }
    }
}