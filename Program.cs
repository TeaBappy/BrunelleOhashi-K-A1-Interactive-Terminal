using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Choose the right option and you'll reach the proper ending.");
        Console.WriteLine($"Ahead of you lies two paths. Path 1 seems welcoming while path 2 seems dangerous. \nWhich Path will you choose: ");
        // Getting this to work took 3 hours between trying to remember what the hell int.parse(); meant and trying to get different outcomes
        // Three hours in and now I'm trying to get the else function to work in case the user inputs anything other than 1 or 2
        // Currentky its just hard to understand and remember what does what and where to put it, its a game of memory and my memory is clinically bad 
        string pic = Console.ReadLine();
        
        int input = int.Parse(pic);
       
        if (input == 2)
        {
            Console.WriteLine($"A thick fog envelops the path, you loose your footing and fall to your death. \nYOU DIED! Press any button to try again.");


        }
        if (input >= 3)
        {
            Console.WriteLine("The Wizard instantly smites you down! \nYOU DIED. Press any button to try again.");
        }

        if (input == 1)
        {   
         
            Console.WriteLine($"You continue down the path before encountering a wizard");
            Console.WriteLine($"This Wizard presents you with a challenge.");
            Console.WriteLine($"He says, Depending on your health, I will either let you pass or I will smite you here and now.");
            Console.WriteLine($"So adventurer, I ask you, on a scale from 1 to 100, what is your current health in numbers?");
           
            // Having trouble with identifying why defining another int/console realine wont work
            // did string health = Console.ReadLine();, int health = int.parse(hp);, then tried if (health <= 50) but it kept 
            // giving me an error so im using the initial int that i established instead
            if (input <= 50)
            {
                Console.WriteLine($"Hm, I see.");
                Console.WriteLine("bullshit");
            }

        }
    }
}
