using System;
using System.Threading;


System.Console.WriteLine("Hello and welcome to, 50 cents richer!!");


string Answer = "";

while (Answer != "a" && Answer != "b")
{
    System.Console.WriteLine($"First question! How many legs does a horse have? A) 279 B) 4 C) 5");


    Answer = Console.ReadLine();
    Answer = Answer.ToLower();
}

if (Answer == "a")
{
    System.Console.WriteLine("lol.");
    Console.ReadLine();
}


if (Answer == "b")
{
    System.Console.WriteLine("You got it, nice job.");
    Console.ReadLine();

    string nextanswer;
    while (true)
    {
        System.Console.WriteLine("Second question! How long is a 10ft deep pit? A) 10ft B) 1ft C) 27m of dirt");
        Console.ReadLine();
        //while (nextanswer != c)? didnt work
        //develop until question three
        


    }





}

if (Answer == "c")
{
    System.Console.WriteLine("bruh.");
    Console.ReadLine();

}



























//int points = 0;







Console.ReadLine();

