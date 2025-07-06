// importing namespaces for in-built methods
using System;
using System.Collections.Generic; // namespace for dictionary data type

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myBio = new Dictionary<string, string>(); // create a list of key-pairs to store my info
        myBio["name"] = "Aaron";
        myBio["country"] = "Ghana";
        myBio["hobbies"] = "drawing, singing, and playing football";

        Console.WriteLine("Hello, World!");
        Console.WriteLine($"My name is {myBio["name"]}, and I come from {myBio["country"]}. My hobbies are {myBio["hobbies"]}");
        Console.WriteLine("Let's have some fun together!");
    }
}