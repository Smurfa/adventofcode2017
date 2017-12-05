using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2017
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<int> CharToIntegerEnumerable(this IEnumerable<char> input)
        {
            return input.Select(x => int.Parse(x.ToString()));
        }

        public static IEnumerable<int> StringToIntegerEnumerable(this IEnumerable<string> input)
        {
            return input.Select(x => int.Parse(x.ToString()));
        }
    }
}
