using System;
using System.Linq;

public class Kata
{
  public static string ToCamelCase(string str) {

    return string
      .Concat(str
      .Split(new char[] { '-', '_' })
      .Select((word, index) => index == 0 ? word : char.ToUpper(word[0]) + word.Substring(1)));
  }
}