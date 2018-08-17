using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Agent myAgent = new Agent();
            myAgent.Name = "Dimitrius";

            string userResponse = Console.ReadLine();

            Room room1 = new Room();
            room1.Name = "living room";
            room1.Size = "400 sq. ft.";
            room1.Remodeled = true;

            Room room2 = new Room();
            room2.Name = "kitchen";
            room2.Size = "200 sq. ft.";
            room2.Remodeled = true;

            Room room3 = new Room();
            room3.Name = "bathroom";
            room3.Size = "100 sq. ft.";
            room3.Remodeled = true;

            Room room4 = new Room();
            room4.Name = "bedroom";
            room4.Size = "200 sq. ft.";
            room4.Remodeled = false;

            myAgent.Speak("Hello, my name is " + myAgent.Name + ". Welcome to this open house.");
            myAgent.Speak("Would you like to see the living room first? y/n?");
            Console.ReadLine();

            if (userResponse == "y")
            {
                myAgent.Speak("The " + room1.Name + " is " + room1.Size + ".");

                if (room1.Remodeled == true)
                {
                    myAgent.Speak("This room is newely remodeled.");
                }
                myAgent.Speak("This " + room1.Name + " is a beautiful open space blah blah blah.");
                myAgent.Speak("Would you like to see " + room2.Name + "? y/n?");
                Console.ReadLine();
            }

            if (userResponse == "n")
            {
                myAgent.Speak("Go home!");
                Console.WriteLine();
                myAgent.Speak("Just kidding. Would you like to see the " + room2.Name + "? y/n?");
            }

            Console.ReadLine();

            if (userResponse == "y")
            {
                myAgent.Speak("This " + room2.Name + " is " + room2.Size + ".");
                Console.ReadLine();
            }



        }


    }
}

