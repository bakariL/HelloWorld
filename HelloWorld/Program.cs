using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part one Greetings statement
            string messageOne = "Hello World!";
            string messageTwo = "I am Spartcus";

            ////Part teo set initial Spartucus attributes
            int ageOne = 35;
            int ageTwo = 45;
            int ageThree = 80;
            double heightOne = 72.50;
            double heightTwo = 91.45;
            float weightOne = 210.0284606f;
            float weightTwo = 331.12345678f;
            bool isGodLikeOne = true;
            bool isGodLikeTwo = false;
            char genderMale = 'M';
            char genderFemale = 'F';

            ////Part three display variable values
            ////Console.WriteLine(messageOne); //Displays intial greeting to console 
            ////Console.WriteLine(messageTwo);

            ////Part four mathematical operator, bool and char examples
            //Console.WriteLine(ageOne + ageTwo); // addition example
            //Console.WriteLine(heightOne - heightTwo); //Subraction example 
            //Console.WriteLine(weightOne * weightTwo); //multiplication example
            //Console.WriteLine(isGodLikeOne); //Bool example 
            //Console.WriteLine(genderMale); //Char example 

            ////Part Five variable reassignment 
            //ageTwo = 70;
            //weightTwo = -429.1234573f;
            //heightTwo = 35.12345f;

            ////Part Six mathematical operator examples 
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(ageTwo / ageOne);
            //Console.WriteLine(ageTwo % ageOne);
            //Console.WriteLine(ageThree / ageOne);
            //Console.WriteLine(ageThree % ageOne);

            ////Part Seven increment and decrement operator examples
            //ageTwo++;
            //Console.WriteLine(ageTwo);
            //ageTwo--;
            //Console.WriteLine(ageTwo);

            //Console.WriteLine(11 < 4);
            //Console.WriteLine("5" == "5");
            //Console.WriteLine(40 != 40);


            //Part eight concatention example 
            Console.WriteLine(messageOne + "" + messageTwo + ".");

            //I am 35 years old, and yes it's true I am godlike. 
            Console.WriteLine("I am " + ageOne + "old, and yes it's " + isGodLikeOne + " i am godlike." );
            Console.WriteLine("I am {0} years old, and yes it's {1} i am godlike.", ageOne, isGodLikeOne);

            //I weigh around 210 pounds, and i am around 72 inches tall.
            Console.WriteLine("I weigh around " + weightOne + "pounds, and i am around " + heightOne + " inches tall.");
            Console.WriteLine("I weigh around {0} pounds and, i am around {1} inches tall.", weightOne, heightOne);


            ////Part nine string equality examples
            //Console.WriteLine(messageTwo.Equals(messageOne));
            //Console.WriteLine(messageTwo.Equals("I am Spartcus"));

            //string myGreeting = "Hello";
            //Console.WriteLine(myGreeting.ToUpper()); //print "HELLO"
            //Console.WriteLine(myGreeting.ToLower()); //print "hello"
            //Console.WriteLine(myGreeting); //prints "Hello"

            ////Part ten string length examples
            //int messOneLength = messageOne.Length;
            //int messTwoLength = messageTwo.Length;

            //Console.WriteLine("The length of messageOne is " + messageOne.Length);
            //Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            //Console.WriteLine("The length of messageOne is " + messOneLength);
            //Console.WriteLine("The length of messageTwo is " + messTwoLength);

            ////Part eleven conditional examples
            //string city1 = "Vesuvius";
            //string city2 = "Nola";
            //string city3 = "Nuceria";
            //int city1Distance, city2Distance, city3Distance;

            ////Solicit user input example
            //Console.WriteLine("What is the distance to {0}?", city1);
            //city1Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to " + city2 + "?");
            //city2Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to Nuceria?");
            //city3Distance = int.Parse(Console.ReadLine());

            //if ((city1Distance <= 125) && ((city1Distance < city2Distance ) && (city1Distance < city3Distance)))
            //{
            //    Console.WriteLine("We will march to Cesuvis");
            //}
            //if ((city2Distance <= 125 ) && ((city2Distance < city1Distance) && (city2Distance < city3Distance)))
            //{
            //    Console.WriteLine("We will march to Nola");
            //}
            //if ((city3Distance <= 125) && ((city3Distance < city1Distance) && (city3Distance < city2Distance)))
            //{
            //    Console.WriteLine("We will march to Nuceria");
            //}

            //Part eleven conditonal examples 
            string city1 = "Vesuvius";
            string city2 = "Nola";
            string city3 = "Nuceria";
            string vesuvius;
            string nola;
            string nuceria;

            //Solicit user input example
            Console.WriteLine("What is the weather in {0}?", city1);
            vesuvius = Console.ReadLine();
            Console.WriteLine("What is the weather in " + city2 + "?");
            nola = Console.ReadLine();
            Console.WriteLine("What is the weather ");

            Console.WriteLine("What is Your Rank Solider?");
            string rank = Console.ReadLine();

            Console.WriteLine("What is your age solider?");
            string job = Console.ReadLine();

            if ((rank == "officer") || (ageOne <= 26))
            {
                Console.WriteLine("Get your gear, kiss your family goodbye, put your marching boots.");
            }
            else if ((job == "cook") || (ageOne >= 26))
            {
                Console.WriteLine("My army has to eat. Pack your pots and pans");
            }
            else
            {
                Console.WriteLine("Sorry you are staying home.");
            }

            
            switch(job)
            {
                case "infantry":
                    Console.WriteLine("You will carry a sword.");
                    break;

                case "archers":
                    Console.WriteLine("You will carry a bow and arrow.");
                    break;

                case "supply":
                    Console.WriteLine("You will carry pots and pans.");
                    break;

                case "specialist":
                    Console.WriteLine("You will operate the catapult");
                    break;

                default:
                    Console.WriteLine("You will ride horseback");
                    break;
            }



        }
    }
}
