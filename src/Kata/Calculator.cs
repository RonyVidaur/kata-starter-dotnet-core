using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s = "")
        {
            if(string.IsNullOrEmpty(s))
                return 0;
            var numbers = s.Split(",", StringSplitOptions.None);
            if (numbers.Count() > 1)
            {
                var nums = numbers.Select(int.Parse);
                return nums.First() + nums.Last();    
            }

            return int.Parse(numbers.First());
        }
    }
}