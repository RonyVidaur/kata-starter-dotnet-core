namespace Kata
{
    public class Calculator
    {
        public int Add(string s  =  "")
        {
            if(string.IsNullOrEmpty(s))
                return 0;

            if (s.IndexOf(',') == -1)
            {
                return int.Parse(s);
            }

            var numbers = s.Split(',');
            return int.Parse(numbers[0]) + int.Parse(numbers[1]);
        }
    }
}