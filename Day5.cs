using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2017
{
    public class Day5
    {
        private List<int> _data;
        public Day5(string filepath)
        {
            _data = ReadFile.AsEnumerableInt(filepath).ToList();
        }

        public void ResetData(string filepath)
        {
            _data = ReadFile.AsEnumerableInt(filepath).ToList();
        }

        public int Task1()
        {
            var steps = 0;
            var index = 0;
            while (index < _data.Count)
            {
                index += _data[index]++;
                steps++;
            }
            return steps;
        }

        public int Task2()
        {
            var steps = 0;
            var index = 0;
            while (index < _data.Count)
            {
                var jumpsToMake = _data[index];
                if (jumpsToMake >= 3)
                    _data[index]--;
                else
                    _data[index]++;

                index += jumpsToMake;
                steps++;
            }
            return steps;
        }
    }
}
