using System;
using System.Linq;

public class Kata
{
  public static bool IsValidWalk(string[] walk)
  {
    if(walk.Length != 10)
      return false;
    
    int x = 0, y = 0;
    
    foreach(string direction in walk) {
      switch(direction) {
        case "n":
          y++;
          break;
        case "s":
          y--;
          break;
        case "w":
          x--;
          break;
        case "e":
          x++;
          break;
        }
      }
    
    return (x == 0 && y == 0) ? true : false;
  }
}