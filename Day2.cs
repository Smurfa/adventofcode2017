using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2017
{
    public class Day2
    {
        private readonly IEnumerable<IEnumerable<int>> _data;

        public Day2(string filepath)
        {
            _data = ReadInput(filepath);
        }

        public int Task1()
        {
            return _data.Sum(x => x.Max() - x.Min());
        }

        public int Task2()
        {
            return _data.Sum(list =>
                list.Sum(dividend =>
                    list.Where(divisor => dividend % divisor == 0 && dividend != divisor)
                        .Sum(divisor => dividend / divisor)));
        }

        private IEnumerable<IEnumerable<int>> ReadInput(string filepath)
        {
            var lines = File.ReadAllText(filepath).Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            return lines.Select(line => line.Split('\t').Select(int.Parse));
        }
    }
}
