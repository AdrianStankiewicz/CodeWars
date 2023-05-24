using System;
using System.Linq;

public class Kata 
{
    
    public static bool Scramble(string str1, string str2) 
    {
        foreach(char ch in str2) {
          if(!str1.Contains(ch))
              return false;
          
          str1 = str1.Remove(str1.IndexOf(ch), 1);
        }
      
        return true;
    }
}