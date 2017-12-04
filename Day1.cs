using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2017
{
    public class Day1
    {
        private readonly string _numbers;

        public Day1(string numbers)
        {
            _numbers = numbers;
        }

        public int Task1()
        {
            var numbers = _numbers.ToCharArray().CharToIntegerEnumerable().ToList();
            var sum = 0;

            for (var i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                    sum += numbers[i];
            }
            if (numbers[0] == numbers[numbers.Count - 1])
                sum += numbers[0];

            return sum;
        }

        public int Task2()
        {
            var numbers = _numbers.ToCharArray().CharToIntegerEnumerable().ToList();

            var sum = 0;

            for (var i = 0; i < numbers.Count; i++)
            {
                var offset = i + numbers.Count / 2;
                if (offset >= numbers.Count)
                    offset -= numbers.Count;

                if (numbers[i] == numbers[offset])
                    sum += numbers[i];
            }

            return sum;
        }
    }
}
