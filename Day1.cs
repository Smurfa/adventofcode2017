using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2017
{
    public class Day1
    {
        public int Task1(string value)
        {
            var numbers = value.ToCharArray().CharToIntegerEnumerable();
            var sum = 0;

            for (var i = 0; i < numbers.Count() - 1; i++)
            {
                if (numbers.ElementAt(i) == numbers.ElementAt(i + 1))
                    sum += numbers.ElementAt(i);
            }
            if (numbers.ElementAt(0) == numbers.ElementAt(numbers.Count() - 1))
                sum += numbers.ElementAt(0);

            return sum;
        }
    }
}
