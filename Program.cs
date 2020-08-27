using System;

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
            Console.WriteLine($"My friends are {firstFriend},{secondFriend},{thirdFriend},{fourthFriend},{fifthFriend},{sixthFriend},{seventhFriend},{eighthFriend} and {ninthFriend}");

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

        }
    }
}