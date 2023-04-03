// Link: https://www.codewars.com/kata/554b4ac871d6813a03000035

using System;
using System.Linq;

namespace Challenges
{
    public static class KataHighAndLow
    {
        public static string HighAndLow(string numbers)
        {
                    var list = numbers.Split(' ').Select(s => int.TryParse(s, out int value) ? value : 0);
                    return list.Max() + " " + list.Min();
        }
    }
}