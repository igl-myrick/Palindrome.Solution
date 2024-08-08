using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;
using System;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeVerifierTests
  {
    [TestMethod]
    public void PalindromeVerifierConstructor_CreatesInstanceOfPalindromeVerifier_PalindromeVerifier()
    {
      PalindromeVerifier newPhrase = new PalindromeVerifier("level");
      Assert.AreEqual(typeof(PalindromeVerifier), newPhrase.GetType());
    }

    [TestMethod]
    public void ReverseStr_ReturnsUserInput_String()
    {
      PalindromeVerifier newPhrase = new PalindromeVerifier("level");
      Assert.AreEqual("level", newPhrase.ReverseStr());
    }

    [TestMethod]
    public void ReverseStr_ReturnsUserInputReversed_String()
    {
      PalindromeVerifier newPhrase = new PalindromeVerifier("levels");
      Assert.AreEqual("slevel", newPhrase.ReverseStr());
    }

    [TestMethod]
    public void CheckIfValid_ReturnTrueIfValid_Boolean()
    {
      PalindromeVerifier newPhrase = new PalindromeVerifier("level");
      Assert.AreEqual(true, newPhrase.CheckIfValid());
    }

    [TestMethod]
    public void CheckIfValid_ReturnFalseIfInvalid_Boolean()
    {
      PalindromeVerifier newPhrase = new PalindromeVerifier("levels");
      Assert.AreEqual(false, newPhrase.CheckIfValid());
    }
  }
}