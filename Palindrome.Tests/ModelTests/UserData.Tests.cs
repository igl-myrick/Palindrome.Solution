using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;
using System;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeVerifierTests
  {
    [TestMethod]
    public void UserDataConstructor_CreatesInstanceOfUserData_UserData()
    {
      UserData newPhrase = new UserData("level");
      Assert.AreEqual(typeof(UserData), newPhrase.GetType());
    }

    [TestMethod]
    public void CheckIfValid_ReturnsUserInput_String()
    {
      UserData newPhrase = new UserData("level");
      Assert.AreEqual("level", newPhrase.CheckIfValid());
    }

    [TestMethod]
    public void CheckIfValid_ReturnsUserInputReversed_String()
    {
      UserData newPhrase = new UserData("levels");
      Assert.AreEqual("slevel", newPhrase.CheckIfValid());
    }
  }
}