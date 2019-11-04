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

      var numbers = s.Split(new[]{",","\n"},StringSplitOptions.None).Select(int.Parse);

      return numbers.Sum();
    }
  }
}