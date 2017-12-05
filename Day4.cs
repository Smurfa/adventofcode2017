using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2017
{
    public class Day4
    {
        private readonly IEnumerable<IEnumerable<string>> _data;

        public Day4(string filepath)
        {
            _data = ReadFile.AsEnumerableEnumerableString(filepath, new []{ ' ' });
        }

        public int Task1()
        {
            return _data.Count(list =>
                list.Count() == list.Distinct().Count());
        }
    }
}
