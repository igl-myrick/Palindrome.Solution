using System;
using Palindrome.Models;

namespace Palindrome
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to the Palindrome Checker App.");
      Console.WriteLine("Enter a word, number, or phrase to see if it's a valid palindrome:");
      string userInput = Console.ReadLine();
      VerifyInput(userInput);

      static void VerifyInput(string input)
      {
        Console.WriteLine($"Your input: {input}");
        Console.WriteLine("Is this correct? Write 'yes' to continue with the check or 'no' to input a new phrase.");
        string userResponse = Console.ReadLine();
        if (userResponse.ToLower() == "yes")
        {
          UserData newData = new UserData(input);
          string reversedInput = newData.ReverseData();
          CheckInput(newData);
        }
        else
        {
          string newInput = Console.ReadLine();
          VerifyInput(newInput);
        }
      }

      static void CheckInput(UserData input)
      {
        if (input.CheckIfValid() == true)
        {
          Console.WriteLine($"'{input.Input}' is a valid palindrome.");
        }
        else
        {
          Console.WriteLine($"'{input.Input}' is not a valid palindrome.");
        }
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("If you would like to check a new phrase, type 'new'. To exit, enter any key.");
        string userResponse = Console.ReadLine();
        if (userResponse.ToLower() == "new")
        {
          Main();
        }
        else
        {
          Console.WriteLine("Goodbye!");
        }
      }
    }
  }
}