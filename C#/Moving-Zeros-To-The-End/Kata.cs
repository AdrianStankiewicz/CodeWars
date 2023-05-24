using System;
using System.Linq;

public class Kata
{
  public static int[] MoveZeroes(int[] arr) => 
    arr
      .Where(n => n != 0)
      .Concat(Enumerable.Repeat(0, arr.Length - arr.Where(n => n != 0).Count()))
      .ToArray();
}