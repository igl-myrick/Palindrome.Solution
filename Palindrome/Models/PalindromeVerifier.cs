using System;

namespace Palindrome.Models
{
  public class PalindromeVerifier
  {
    public string Input { get; set; }

    public PalindromeVerifier(string userStr)
    {
      Input = userStr;
    }

    public string ReverseStr()
    {
      char[] inputArr = Input.ToCharArray(0, Input.Length);
      Array.Reverse(inputArr);
      string result = String.Concat(inputArr);
      return result;
    }

    public bool CheckIfValid()
    {
      if (ReverseStr() == Input)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}