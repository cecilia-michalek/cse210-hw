using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation3 World!");
        Address address1 = new Address("585 N Appellation", "Saratoga", "NY", "USA");
        Address address2 = new Address("10 W Laow Ln", "Catalina", "CA", "USA");
        Address address3 = new Address("123 New Port Beach", "Los Angeles", "CA", "USA");

        //DateTime eventDate = new DateTime(2024, 10, 08);

        Lecture lecture = new Lecture("Lecture", "Mental Health", "How to better cope with the loss of a loved one.", DateTime.Now, 18, address1, "Kathy Bolock", 50);
        Reception reception = new Reception("Reception","Support Group", "Get to know your Mentors.", DateTime.Now, 15, address2, "sallySmith@msn.com");
        Outdoor outdoor = new Outdoor("Outdoor", "Walk by the Beach", "Fun outdoor activity to get your mind disconected.", DateTime.Now, 13, address3, "Sunny");
        

        Console.WriteLine();
        lecture.Activity();
        Console.WriteLine();
        reception.Activity();
        Console.WriteLine();
        outdoor.Activity();
        Console.WriteLine();
    }
}