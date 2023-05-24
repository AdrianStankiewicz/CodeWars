# Kata content:
Complete the method/function so that it converts dash/underscore delimited words into camel casing. The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case). The next words should be always capitalized.
___
### Examples
```"the-stealth-warrior"``` gets converted to ```"theStealthWarrior"```

```"The_Stealth_Warrior"``` gets converted to ```"TheStealthWarrior"```

```"The_Stealth-Warrior"``` gets converted to ```"TheStealthWarrior"```
```
___
# Provided tests:
```C#
using System;
using NUnit.Framework;

[TestFixture]
public class KataTest
{
  [Test]
  public void KataTests()
  {
    Assert.AreEqual("theStealthWarrior", Kata.ToCamelCase("the_stealth_warrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
    Assert.AreEqual("TheStealthWarrior", Kata.ToCamelCase("The-Stealth-Warrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
  }
}
```