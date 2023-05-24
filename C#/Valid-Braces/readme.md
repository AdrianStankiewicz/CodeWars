# Kata content:
Write a function that takes a string of braces, and determines if the order of the braces is valid. It should return ```true``` if the string is valid, and ```false``` if it's invalid.

This Kata is similar to the Valid Parentheses Kata, but introduces new characters: brackets ```[]```, and curly braces ```{}```. Thanks to ```@arnedag``` for the idea!

All input strings will be nonempty, and will only consist of parentheses, brackets and curly braces: ```()[]{}```.

What is considered Valid?
A string of braces is considered valid if all braces are matched with the correct brace.
___
### Examples
```
"(){}[]"   =>  True
"([{}])"   =>  True
"(}"       =>  False
"[(])"     =>  False
"[({})](]" =>  False
```
___
# Provided tests:
```C#
namespace Solution 
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void SampleTest()
    {
      Assert.AreEqual(true, Kata.IsValidWalk(new string[] {"n","s","n","s","n","s","n","s","n","s"}), "should return true");
      Assert.AreEqual(false, Kata.IsValidWalk(new string[] {"w","e","w","e","w","e","w","e","w","e","w","e"}), "should return false");
      Assert.AreEqual(false, Kata.IsValidWalk(new string[] {"w"}), "should return false");
      Assert.AreEqual(false, Kata.IsValidWalk(new string[] {"n","n","n","s","n","s","n","s","n","s"}), "should return false");
    }
  }
}
```