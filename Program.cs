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
            /*Task 1: 
             Create a program where you declare variables for storing person name and birth year. Give
             values to those variables that correspond to your own data. Declare also a variable that
             represents a reference year and assign it to the value of the current year. With these variables
             calculate your current age, store it in a new variable and output the data in the format:
             */
            //Copy paste your program here:

            String name;
            int yrOfBirth;

            name = "vu le";
            yrOfBirth = 1995;

            int currentYear = 2018;
            int age = currentYear - yrOfBirth;

            Console.WriteLine($"{name}, {age} years");

            /*Task 2:
                Create a program which calculates, stores in appropriately declared variables and finally prints
                on the screen the answers to the following questions:
            */
            const int FINGER_OF_PLAYER = 10;
            const int FEET_OF_PLAYER = 1;
            const int NUM_OF_PLAYER_IN_TEAM = 11;

            int numOfPlayers;

            //a) How many feet and fingers a group of people of given size have in together
            numOfPlayers = 100;
            int totalFingers = numOfPlayers * FINGER_OF_PLAYER;
            int totalFeet = numOfPlayers * FEET_OF_PLAYER;
            Console.WriteLine($"{numOfPlayers} persons have {totalFeet} feet and {totalFingers} fingers");

            numOfPlayers = 123456789;
            totalFingers = numOfPlayers * FINGER_OF_PLAYER;
            totalFeet = numOfPlayers * FEET_OF_PLAYER;
            Console.WriteLine($"{numOfPlayers} persons have {totalFeet} feet and {totalFingers} fingers");

            //b) How many football teams can a group of a given size form (11 players per team)
            numOfPlayers = 100;
            int numOfTeams = numOfPlayers / NUM_OF_PLAYER_IN_TEAM;
            int numLeftOutPlayers = numOfPlayers - numOfTeams * NUM_OF_PLAYER_IN_TEAM;
            Console.WriteLine($"{numOfPlayers} persons form {numOfTeams} teams and {numLeftOutPlayers} persons are left out");

            numOfPlayers = 123456789;
            numOfTeams = numOfPlayers / NUM_OF_PLAYER_IN_TEAM;
            numLeftOutPlayers = numOfPlayers - numOfTeams * NUM_OF_PLAYER_IN_TEAM;
            Console.WriteLine($"{numOfPlayers} persons form {numOfTeams} teams and {numLeftOutPlayers} persons are left out");

            //c) How many balls is required if each team needs three balls
            numOfPlayers = 100;
            numOfTeams = numOfPlayers / NUM_OF_PLAYER_IN_TEAM;
            int numOfBalls = numOfTeams * 3;
            Console.WriteLine($"{numOfTeams} football teams require {numOfBalls} balls");

            numOfPlayers = 123456789;
            numOfTeams = numOfPlayers / NUM_OF_PLAYER_IN_TEAM;
            numOfBalls = numOfTeams * 3;
            Console.WriteLine($"{numOfTeams} football teams require {numOfBalls} balls");

            //d) How many players are left outside a team after filling all the teams with 11 players

            // ALREADY ANSWER IN b.

            /*Task3:
            3	Create a program which defines a named constant to denote the value of Pi (= 3.14159) and 
            appropriate variables to describe the radius r, area A and circumference c of a sphere. 
            */
            const double PI = 3.14;
            double r, area, cir;

            r = 1.0;
            cir = 2 * PI * r;
            area = PI * r * r;
            Console.WriteLine($"Radius: {r}, Area: {area}, Circumference: {cir}");

            r = 5.0;
            cir = 2 * PI * r;
            area = PI * r * r;
            Console.WriteLine($"Radius: {r}, Area: {area}, Circumference: {cir}");

            r = 10.0;
            cir = 2 * PI * r;
            area = PI * r * r;
            Console.WriteLine($"Radius: {r}, Area: {area}, Circumference: {cir}");

            /*Task 4:
             "how many bits are there in one kilo/mega/giga/terabyte?"
            */
            const int BIT_PER_BYTE = 8;
            const int BYTE_PER_KILOBYTE = 1024;
            const int KILOBYTE_PER_MEGABYTE = 1024;
            const int MEGABYTE_PER_GIGABYTE = 1024;
            const int GIGABYTE_PER_TERABYTE = 1024;

            long bitPerTerra = (long)GIGABYTE_PER_TERABYTE * MEGABYTE_PER_GIGABYTE * KILOBYTE_PER_MEGABYTE * BYTE_PER_KILOBYTE * BIT_PER_BYTE;
            long bitPerGiga = (long)MEGABYTE_PER_GIGABYTE * KILOBYTE_PER_MEGABYTE * BYTE_PER_KILOBYTE * BIT_PER_BYTE;
            int bitPerMega = KILOBYTE_PER_MEGABYTE * BYTE_PER_KILOBYTE * BIT_PER_BYTE;
            int bitPerKilo = BYTE_PER_KILOBYTE * BIT_PER_BYTE;

            Console.WriteLine($"1 Terrabyte has {bitPerTerra} bits");
            Console.WriteLine($"1 Gigabyte has {bitPerGiga} bits");
            Console.WriteLine($"1 Megabyte has {bitPerMega} bits");
            Console.WriteLine($"1 Kilobyte has {bitPerKilo} bits");
            Console.WriteLine($"1 byte has {BIT_PER_BYTE} bits");
            /*
            Task 5:
            "for a given amount of bits (as constant) how many
             tera-, giga-, mega- and kilobytes they correspond 
             to and how many bits are left over"
            */

            long bits = 123456789123456789;
            int teras = (int)(bits / ((long)GIGABYTE_PER_TERABYTE * MEGABYTE_PER_GIGABYTE * KILOBYTE_PER_MEGABYTE * BYTE_PER_KILOBYTE * BIT_PER_BYTE));

            long bitLeftOver = (int)(bits % ((long)GIGABYTE_PER_TERABYTE * MEGABYTE_PER_GIGABYTE * KILOBYTE_PER_MEGABYTE * BYTE_PER_KILOBYTE * BIT_PER_BYTE));
            int gigas = (int)(bitLeftOver / ((long)MEGABYTE_PER_GIGABYTE * KILOBYTE_PER_MEGABYTE * BYTE_PER_KILOBYTE * BIT_PER_BYTE));

            bitLeftOver = (int)(bitLeftOver % ((long)MEGABYTE_PER_GIGABYTE * KILOBYTE_PER_MEGABYTE * BYTE_PER_KILOBYTE * BIT_PER_BYTE));
            int megas = (int)(bitLeftOver / (KILOBYTE_PER_MEGABYTE * BYTE_PER_KILOBYTE * BIT_PER_BYTE));

            bitLeftOver = (int)(bitLeftOver % ((long)KILOBYTE_PER_MEGABYTE * BYTE_PER_KILOBYTE * BIT_PER_BYTE));
            int kilos = (int)(bitLeftOver / (BYTE_PER_KILOBYTE * BIT_PER_BYTE));

            bitLeftOver = (int)(bitLeftOver % (BYTE_PER_KILOBYTE * BIT_PER_BYTE));
            int bytes = (int)(bitLeftOver / (BIT_PER_BYTE));

            bitLeftOver = (int)(bitLeftOver % BIT_PER_BYTE);

            Console.WriteLine($"{bits} bits correspond to\n{teras} terabytes\n{gigas} gigabytes\n{megas} megabytes\n {kilos} kilobytes\n{bytes} bytes\nand {bitLeftOver} bits");
        }
    }
}