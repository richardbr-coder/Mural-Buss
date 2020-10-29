using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mural_Buss
{
    class Program
    {
        static void Main(string[] args)
        {
            //User enters their MONTH here
            int numVar1; 
            string input;
            const int LOW = 1;
            const int HIGH = 12;

            Console.Write("Enter your month number: ");
            input = Console.ReadLine();
            numVar1 = Convert.ToInt32(input);


            while (numVar1 < LOW || numVar1 > HIGH)
            {
                Console.WriteLine("invalid number. Month number must be between 1 & 12.  ", numVar1);
                Console.Write("Please enter your month number: ", LOW, HIGH);
                input = Console.ReadLine();
                numVar1 = Convert.ToInt32(input);

            }
            Console.WriteLine(); // I hope its okay with you but I like the gap between each statement in the console, I find it easier to read! :)


            //INTERIOR Murals to be completed
            int numVar2;
            string input2;
            const int LOW2 = 0;
            const int HIGH2 = 30;

            Console.Write("Enter the number of interior murals scheduled: ");
            input2 = Console.ReadLine();
            numVar2 = Convert.ToInt32(input2);

            while (numVar2 < LOW2 || numVar2 > HIGH2)
            {
                Console.WriteLine("invalid number. Number of interior murals must be between 0 & 30.");
                Console.Write("Please enter the number of interior murals to be completed: ");
                input2 = Console.ReadLine();
                numVar2 = Convert.ToInt32(input2);

            }
            Console.WriteLine();// I hope its okay with you but I like the gap between each statement in the console, I find it easier to read! :)


            //EXTERIOR Murals to be completed
            int numVar3;
            string input3;
            const int LOW3 = 0;
            const int HIGH3 = 30;

            Console.Write("Enter the number of exterior murals scheduled: ");
            input3 = Console.ReadLine();
            numVar3 = Convert.ToInt32(input3);


            while (numVar3 < LOW3 || numVar3 > HIGH3)
            {

                Console.WriteLine("invalid number. Number of exterior murals must be between 0 & 30.");
                Console.Write("Please enter the number of exterior murals to be completed: ");
                input3 = Console.ReadLine();
                numVar3 = Convert.ToInt32(input3);

            }
                Console.WriteLine();// I hope its okay with you but I like the gap between each statement in the console, I find it easier to read! :)


            //PRICING varibles used to display a total price for the user on the console
            int i = numVar2;
            int ip = 500;
            int ipd = 450;
            int e = numVar3;
            int ep = 750;
            int epd = 699;
            
            //INTERIOR price models
            if (numVar1 <= 6 ^ numVar1 >= 9)
                Console.WriteLine(numVar2 + " interior murals are scheduled at $500.00 each for a total of $" +numVar2 * ip);
            else if (numVar1 == 7 ^ numVar1 == 8)
                Console.WriteLine(numVar2 + " interior murals are scheduled at $450.00 each for a total of $" + numVar2 * ipd);



             //EXTERIOR price models
            if (numVar1 < 3 ^ numVar1 > 11)
                Console.WriteLine("0 exterior murals are scheduled at $750.00 each for a total of $0.00");
            else if (numVar1 <= 3 ^ numVar1 == 11 ^ numVar1 == 6 ^ numVar1 == 7 ^ numVar1 == 8)
                Console.WriteLine(numVar3 + " exterior murals are scheduled at $750.00 each for a total of $" + numVar3 * ep);
            else if (numVar1 == 4 ^ numVar1 == 5 ^ numVar1 == 9 ^ numVar1 == 10)
                Console.WriteLine(numVar3 + " exterior murals are scheduled at $699.00 each for a total of $" + numVar3 * epd);
            
                Console.WriteLine();// I hope its okay with you but I like the gap between each statement in the console, I find it easier to read! :)


            //Total to be paid by the client which is also the total revenue for the  business 
            if (numVar1 < 3 ^ numVar1 > 11)
                Console.WriteLine("Total revenue expected is $" + (numVar2 * ip));
            if (numVar1 == 4 ^ numVar1 == 5 ^ numVar1 == 9 ^ numVar1 == 10)
                Console.WriteLine("Total revenue expected is $" + (numVar2 * ip + numVar3 * epd));
            if (numVar1 == 7 ^ numVar1 == 8)
                Console.WriteLine("Total revenue expected is $" + (numVar2 * ipd + numVar3 * ep));
            if (numVar1 == 3 ^ numVar1 == 6 ^ numVar1 == 11)
                Console.WriteLine("Total revenue expected is $" + (numVar2 * ip + numVar3 * ep));
            
                Console.WriteLine();// I hope its okay with you but I like the gap between each statement in the console, I find it easier to read! :)


            //which one has more mural scheduled, INTERIOR or EXTERIOR
            if (numVar2 > numVar3)
                Console.WriteLine("There are more interior murals scheduled than exterior ones.");
            else if (numVar3 > numVar2)
                Console.WriteLine("There are more exterior murals scheduled than interior ones.");
            else if (numVar2 == numVar3)
                Console.WriteLine("There are an equal number of interior & exterior murals.");
            else
                Console.WriteLine("ERROR");
            


            Console.ReadLine();

        }
    }
}
