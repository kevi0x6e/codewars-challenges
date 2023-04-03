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