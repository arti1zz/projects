using System;
using System.Linq;

namespace WindowsFormsApplication2
{
    class actions
    {
        public bool check(string input)                                 //is input empty or in range of 2-15
        {
            if (input == "") return false;
            return (int.Parse(input) > 1 && int.Parse(input) < 16);
        }
        public int ranNum()                                             //random number generator
        {
            return new Random().Next(5, 10);
        }
        public string ranString()                                       //random string generator
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, ranNum())
                .Select(s => s[random.Next(s.Length)]).ToArray());  
        }
    }
}
