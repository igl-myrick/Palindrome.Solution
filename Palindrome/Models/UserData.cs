namespace Palindrome.Models
{
  public class UserData
  {
    public string Input { get; set; }

    public UserData(string userData)
    {
      Input = userData;
    }
  }
}