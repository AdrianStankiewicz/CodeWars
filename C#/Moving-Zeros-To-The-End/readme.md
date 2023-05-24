# Kata content:
Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

```C#
Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
```
___
# Provided tests:
```C#
namespace Solution 
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class Sample_Test
  {
    [Test]
    public void Test()
    {
      Assert.AreEqual(new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}, Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}));
    }
  }
}
```