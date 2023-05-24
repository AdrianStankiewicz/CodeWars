# Kata content:
Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2, otherwise returns false.
___
### Notes:
- Only lower case letters will be used (a-z). No punctuation or digits will be included.
- Performance needs to be considered.
___
### Examples
```C#
scramble('rkqodlw', 'world') ==> True
scramble('cedewaraaossoqqyt', 'codewars') ==> True
scramble('katas', 'steak') ==> False
```
___
# Provided tests:
```C#
using System;
using NUnit.Framework;

[TestFixture]
public static class ScrambliesTests 
{

    private static void testing(bool actual, bool expected) 
    {
        Assert.AreEqual(expected, actual);
    }

[Test]
    public static void test1() 
    {
        testing(Scramblies.Scramble("rkqodlw","world"), true);
        testing(Scramblies.Scramble("cedewaraaossoqqyt","codewars"),true);
        testing(Scramblies.Scramble("katas","steak"),false);
        testing(Scramblies.Scramble("scriptjavx","javascript"),false);
        testing(Scramblies.Scramble("scriptingjava","javascript"),true);
        testing(Scramblies.Scramble("scriptsjava","javascripts"),true);
        testing(Scramblies.Scramble("javscripts","javascript"),false);
        testing(Scramblies.Scramble("aabbcamaomsccdd","commas"),true);
        testing(Scramblies.Scramble("commas","commas"),true);
        testing(Scramblies.Scramble("sammoc","commas"),true);
    }
}

```