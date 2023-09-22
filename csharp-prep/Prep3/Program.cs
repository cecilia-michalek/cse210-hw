using System;

class Program
{
    static void Main(string[] args)
    {
        //This progrsm will first ask the user for a magic number and then give a guess number.
      /*Console.WriteLine("What is the magic number? ");
      string userNumber = Console.ReadLine();
      int magicNumber = int.Parse(userNumber);*/

      Random randomGenerator = new Random();
      int magicNumber = randomGenerator.Next(1, 101);

 
      int guessNumber; 
      bool guess = false;

    while (!guess) {

      Console.WriteLine("what is your guess number from 1 to 100? ");
      string userInput = Console.ReadLine();
      guessNumber = int.Parse(userInput);

  
      if (guessNumber > magicNumber) {
        Console.WriteLine("Go Lower!");
     }
      else if (guessNumber < magicNumber) {
        Console.WriteLine("Go higher!");
     }
      else {
        Console.WriteLine("You guessed it!!");
        guess = true;
        

     }
    
}


}}