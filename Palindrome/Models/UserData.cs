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

    public string ReversedData()
    {
      char[] inputArr = Input.ToCharArray(0, Input.Length);
      Array.Reverse(inputArr);
      string result = String.Concat(inputArr);
      return result;
    }

    public bool CheckIfValid()
    {
      if (ReversedData() == Input)
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