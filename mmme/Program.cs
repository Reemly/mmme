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
if (Answer == "c")
{
    System.Console.WriteLine("bruh.");
    Console.ReadLine();

}


if (Answer == "b")
{
    System.Console.WriteLine("You got it, nice job.");
    Console.ReadLine();

    string nextanswer = "";
    while (nextanswer != "a" && nextanswer != "b")
    {
        System.Console.WriteLine($"Second question! How long is a 10ft deep pit? A) 10ft B) 1ft C) 27m of dirt");
        nextanswer = Console.ReadLine();
        nextanswer = nextanswer.ToLower();
        if (nextanswer == "a")
        {
            System.Console.WriteLine("Why would it be that?");
            Console.ReadLine();

        }
        if (nextanswer == "b")
        {
            System.Console.WriteLine("Do you want these 50 cents or not?");
            Console.ReadLine();


        }

        if (nextanswer == "c")
        {
            System.Console.WriteLine("CORRECT!!!!!!!");
            Console.ReadLine();

            string nextnextanswer = "";
            while (nextnextanswer != "b" && nextnextanswer != "a")
            {
                System.Console.WriteLine($"Third and final question.. what's 9 + 10? A)2l B)18 C)21");
                nextnextanswer = Console.ReadLine();
                nextnextanswer = nextnextanswer.ToLower();

                if (nextnextanswer == "a")
                {
                    System.Console.WriteLine("Why would you pick 2L? that doesn't make sense.");
                    Console.ReadLine();



                }

                if (nextnextanswer == "b")
                {
                    System.Console.WriteLine("You donkey who would answer with correct math to that question?");
                    Console.ReadLine();



                }

                if (nextnextanswer == "c")
                {
                    System.Console.WriteLine("Three right answers in a row!! You have won 50 cents richer!! Congratulations.");
                    Console.ReadLine();

                }





            }










        }








    }







}



























//int points = 0;







Console.ReadLine();

