using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        Video video1 = new Video
        {
            _title = "Introduction to Sewing",
            _author = "Cristy Lee",
            _lengthSec = 550,

        };
        video1.AddComment("Charlie", "Very easy to understand.");
        video1.AddComment("Katy", "Awesome!");

        Video video2 = new Video
        {
            _title = "Sewing for Begginers",
            _author = "Cristy Lee",
            _lengthSec = 500,

        };

        video2.AddComment("Melisa", "Could you explaning step 2 again?");
        video2.AddComment("Cara", "Love the fabric you used!");

        Video video3 = new Video
        {
            _title = "Intermediete Sewing",
            _author = "Sarah Borba",
            _lengthSec = 650,

        };
        video3.AddComment("Bob", "Too many steps to follow");
        video3.AddComment("Laura", "Very complete explanation");

        Video video4 = new Video
        {
            _title = "Advance to Sewing",
            _author = "Sarah Borba",
            _lengthSec = 450,

        };
        video4.AddComment("Charlie", "Loved the video!");

        video1.DisplayInfo();
        video2.DisplayInfo();
        video3.DisplayInfo();
        video4.DisplayInfo();
    }
}