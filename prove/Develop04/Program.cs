using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Activity breatheActivity = new BreatheActivity(4, 6);
        Activity reflectActivity = new ReflectActivity(
            [
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless.",
            ],
            [
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            ],
            10);
        Activity listenActivity = new ListenActivity(
            [
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            ],
        0);
        Menu menu = new Menu();

        int response = 0;
        
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine();

        while (response != 6)
        {
            menu.ShowMenu();
            response = menu.GetResponse();

            if (response == 1)
            {
                breatheActivity.DoActivity();
            }
            else if (response == 2)
            {
                listenActivity.DoActivity();
            }
            else if (response == 3)
            {
                reflectActivity.DoActivity();
            }
            else if (response == 4)
            {
                breatheActivity.ChangeDuration();
            }
            else if (response == 5)
            {
                reflectActivity.ChangeDuration();
            }

            response = 0;

            Console.Clear();
        }

        Console.WriteLine("Thanks for using the Mindfulness Program!");

        Console.WriteLine();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine();
    }
}