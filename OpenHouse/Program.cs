using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Agent myAgent = new Agent() { Name = "Dimitrius" };

            string userResponse = Console.ReadLine();

            Room livingRoom = new Room() { Name = "living room", Size = "400 sq. ft.", Remodeled = true };

            Room kitchen = new Room();
            kitchen.Name = "kitchen";
            kitchen.Size = "200 sq. ft.";
            kitchen.Remodeled = true;

            Room bathroom = new Room();
            bathroom.Name = "bathroom";
            bathroom.Size = "100 sq. ft.";
            bathroom.Remodeled = true;

            Room bedroom = new Room();
            bedroom.Name = "bedroom";
            bedroom.Size = "200 sq. ft.";
            bedroom.Remodeled = false;

            myAgent.Speak("Hello, my name is " + myAgent.Name + ". Welcome to this open house.");
            myAgent.Speak("Would you like to see the living room first? y/n?");
            userResponse = Console.ReadLine();

            if (userResponse == "y")
            {
                myAgent.Speak("The " + livingRoom.Name + " is " + livingRoom.Size + ".");

                if (livingRoom.Remodeled == true)
                {
                    myAgent.Speak("This room is newely remodeled.");
                }
                myAgent.Speak("This " + livingRoom.Name + " is a beautiful open space blah blah blah.");
                myAgent.Speak("Would you like to see " + kitchen.Name + "? y/n?");
                userResponse = Console.ReadLine();
            }

            if (userResponse == "n")
            {
                myAgent.Speak("Go home!");
                Console.WriteLine();
                myAgent.Speak("Just kidding. Would you like to see the " + kitchen.Name + "? y/n?");
            }

            userResponse = Console.ReadLine();

            if (userResponse == "y")
            {
                myAgent.Speak("This " + kitchen.Name + " is " + kitchen.Size + ".");
                Console.ReadLine();
            }



        }


    }
}

