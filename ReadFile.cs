using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2017
{
    public static class ReadFile
    {
        private static IEnumerable<string> ReadLines(string filepath)
        {
            return File.ReadAllText(filepath).Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        }

        public static IEnumerable<IEnumerable<int>> AsEnumerableEnumerableInt(string filepath, char[] delimiters)
        {
            return ReadLines(filepath)
                .Select(line => line.Split(delimiters)
                .Select(int.Parse));
        }

        public static IEnumerable<IEnumerable<string>> AsEnumerableEnumerableString(string filepath, char[] delimiters)
        {
            return ReadLines(filepath)
                .Select(line => line.Split(delimiters));
        }

        public static IEnumerable<int> AsEnumerableInt(string filepath)
        {
            return ReadLines(filepath).StringToIntegerEnumerable();
        }
    }
}
