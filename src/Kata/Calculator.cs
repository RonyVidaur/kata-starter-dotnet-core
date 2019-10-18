using System;
using System.Linq;

namespace Kata
{
  public class Calculator
  {
    public int Add(string s = "")
    {
      if (string.IsNullOrEmpty(s)) return 0;

      var separator = ",";
      if (s.StartsWith("//"))
      {
        var parts = s.Split("\n");
        separator = parts[0].Substring(2, 1);
        s = parts[1];
      }
      var numbers = s.Split(new []{"\n", separator}, StringSplitOptions.None).Select(int.Parse);

      var negatives = numbers.Where(x => x < 0);
      if (negatives.Any())
      {
        throw new Exception($"negatives not allowed: {negatives.First().ToString()}");
      }

      return numbers.Sum();
    }
  }
}