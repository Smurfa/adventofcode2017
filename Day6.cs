using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2017
{
    public class Day6
    {
        private List<int> _values;
        private readonly List<IEnumerable<int>> _permutations;

        public Day6(IEnumerable<int> values)
        {
            _values = values.ToList();
            _permutations = new List<IEnumerable<int>> { values.ToList() };
        }

        public void Reset(IEnumerable<int> values)
        {
            _values.Clear();
            _permutations.Clear();
            _values = values.ToList();
            _permutations.Add(values.ToList());
        }


        public int Task1()
        {
            var run = true;
            while (run)
            {
                var insertions = _values.Max();
                var current = _values.IndexOf(insertions);
                _values[current] = 0;

                while (insertions-- > 0)
                {
                    if (++current >= _values.Count)
                        current -= _values.Count;

                    _values[current]++;
                }

                run = !_permutations.Any(x => x.SequenceEqual(_values));
                _permutations.Add(_values.ToList());
            }

            return _permutations.Count - 1;
        }

        public int Task2()
        {
            var targetList = new List<int>();
            var count = 0;
            while (true)
            {
                var insertions = _values.Max();
                var current = _values.IndexOf(insertions);
                _values[current] = 0;

                while (insertions-- > 0)
                {
                    if (++current >= _values.Count)
                        current -= _values.Count;

                    _values[current]++;
                }

                if (_permutations.Any(x => x.SequenceEqual(_values)) && targetList.Count == 0)
                {
                    targetList = _values;
                    count = 0;
                }
                _permutations.Add(_values.ToList());
                count++;

                if (_permutations.Count(x => x.SequenceEqual(targetList)) >= 3)
                    return count - 1;
            }
        }
    }
}
