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
    public void ReversedData_ReturnsUserInput_String()
    {
      UserData newPhrase = new UserData("level");
      Assert.AreEqual("level", newPhrase.ReversedData());
    }

    [TestMethod]
    public void ReversedData_ReturnsUserInputReversed_String()
    {
      UserData newPhrase = new UserData("levels");
      Assert.AreEqual("slevel", newPhrase.ReversedData());
    }

    [TestMethod]
    public void CheckIfValid_ReturnTrueIfValid_Boolean()
    {
      UserData newPhrase = new UserData("level");
      Assert.AreEqual(true, newPhrase.CheckIfValid());
    }

    public void CheckIfValid_ReturnFalseIfInvalid_Boolean()
    {
      UserData newPhrase = new UserData("levels");
      Assert.AreEqual(false, newPhrase.CheckIfValid());
    }
  }
}