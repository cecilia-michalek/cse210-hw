using System;
using System.Collections.Generic;
using System.Linq; //Needs to be included for Max function to work.

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0) {

            Console.Write("Enter a numbers: ");
    
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number > 0) {
            
            numbers.Add(number);
            }
        
        } 
        //Compute the sum of all the numbers entered by user.
        int sum = 0;  
        foreach (int num in numbers) {
            sum += num;
        }  
        Console.WriteLine($"The sum is: {sum}");

        //Compute the average of the sum of all numbers entered by user.
        //Console.Write(numbers.Count);
        if (numbers.Count > 0) 
        {
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");
        }
        if (numbers.Count > 0)
         {
            int max = numbers.Max();
            Console.WriteLine($"The largest number is: {max}");
        }
           
    }
}