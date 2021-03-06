﻿using System;

namespace Friends
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Friends!");

            string aFriend = "Steve";
            Console.WriteLine(aFriend);
            Console.WriteLine("Hello " + aFriend);

            aFriend = "Brenda";
            Console.WriteLine(aFriend);
            Console.WriteLine("Hello " + aFriend);

            aFriend = "Andy";
            Console.WriteLine(aFriend);
            Console.WriteLine("Hello " + aFriend);

            aFriend = "Mo";
            Console.WriteLine(aFriend);
            Console.WriteLine("Hello " + aFriend);

            aFriend = "Rose";
            Console.WriteLine(aFriend);
            Console.WriteLine("Hello " + aFriend);

            aFriend = "Sage";
            Console.WriteLine(aFriend);
            Console.WriteLine("Hello " + aFriend);

            //String interpolation
            aFriend = "Gavin";
            Console.WriteLine(aFriend);
            Console.WriteLine($"Hey {aFriend}");

            string firstFriend = "Gavin";
            string secondFriend = "Amanda";
            string thirdFriend = "Kelly";
            string fourthFriend = "Faith";
            string fifthFriend = "Anthony";
            string sixthFriend = "James";
            string seventhFriend = "John";
            string eighthFriend = "Tyler";
            string ninthFriend = "Brandon";
            string tenthFriend = "David";
            string eleventhFriend = "Sisi";
            string twelfthFriend = "Zach";

            Console.WriteLine($"My friends are {firstFriend},{secondFriend},{thirdFriend},{fourthFriend},{fifthFriend},{sixthFriend},{seventhFriend},{eighthFriend},{ninthFriend},{tenthFriend},{eleventhFriend} and {twelfthFriend}");

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
            Console.WriteLine($"The name {thirdFriend} has {thirdFriend.Length} letters.");
            Console.WriteLine($"The name {fourthFriend} has {fourthFriend.Length} letters.");
            Console.WriteLine($"The name {fifthFriend} has {fifthFriend.Length} letters.");
            Console.WriteLine($"The name {sixthFriend} has {sixthFriend.Length} letters.");
            Console.WriteLine($"The name {seventhFriend} has {seventhFriend.Length} letters.");
            Console.WriteLine($"The name {eighthFriend} has {eighthFriend.Length} letters.");
            Console.WriteLine($"The name {ninthFriend} has {ninthFriend.Length} letters.");
            Console.WriteLine($"The name {tenthFriend} has {tenthFriend.Length} letters.");
            Console.WriteLine($"The name {eleventhFriend} has {eleventhFriend.Length} letters.");
            Console.WriteLine($"The name {twelfthFriend} has {twelfthFriend.Length} letters.");

            ///Learning Trims {TrimEnd,TrimStart,Trim} (WhiteSpaces)

            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            //[      Hello World!       ]original
            //[Hello World!       ]TrimStart
            //[      Hello World!]TrimEnd
            //[Hello World!]Trim

            //Learning Replace

            string sayHello = "Hello Liam!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            //Replaces Hello with Greetings
            //Greetings World!

            //How to make all the letters upper or lower case
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            //Bool TRUE OR FALSE using Contains
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
            Console.WriteLine(aFriend.Contains("G"));

            //StartsWith or EndsWith
            string poem = "You say goodbye, and I say hello Liam";
            Console.WriteLine(poem.StartsWith("You"));
            Console.WriteLine(poem.EndsWith("goodbye"));
            Console.WriteLine(poem.EndsWith("Liam"));
        }
    }
}