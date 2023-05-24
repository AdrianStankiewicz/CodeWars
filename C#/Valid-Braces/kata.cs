using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
    public static bool validBraces(String braces) {
    Stack<char> stack = new Stack<char>();
    
    foreach(char c in braces) {
      if (c == '(' || c == '{' || c == '[') {
        stack.Push(c);
      }
      else if (c == ')' && (stack.Count == 0 || stack.Pop() != '(')) {
        return false;
      }
      else if (c == '}' && (stack.Count == 0 || stack.Pop() != '{')) {
        return false;
      }
      else if (c == ']' && (stack.Count == 0 || stack.Pop() != '[')) {
        return false;
      }
    }
    
    return stack.Count == 0;
    }
}