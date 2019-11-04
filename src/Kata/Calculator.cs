using System;
using System.Linq;
using System.Net.Sockets;

namespace Kata
{
  public class Calculator
  {
    public int Add(string s = "")
    {
      if (string.IsNullOrEmpty(s)) 
        return 0;

      var separator = "";
      
      if (s.StartsWith("//"))
      {
        var parts = s.Split("\n");
        s = parts[1];
        separator = parts[0].Replace("//", "").Replace("[", "").Replace("]", "");
      }
      
      var numbers = s.Split(new[]{",","\n", separator},StringSplitOptions.None).Select(int.Parse).Where(x=> x<1001);

      var negatives = numbers.Where(x => x < 0);
      
      if (negatives.Any())
      {
        throw new Exception($"negatives not allowed: {string.Join(", ", negatives)}");
      }

      return numbers.Sum();
    }
  }
}