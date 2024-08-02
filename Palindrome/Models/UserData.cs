using System;

namespace Palindrome.Models
{
  public class UserData
  {
    public string Input { get; set; }

    public UserData(string userData)
    {
      Input = userData;
    }

    public string CheckIfValid()
    {
      char[] inputArr = Input.ToCharArray(0, Input.Length);
      Array.Reverse(inputArr);
      string outputStr = String.Concat(inputArr);
      return outputStr;
    }
  }
}