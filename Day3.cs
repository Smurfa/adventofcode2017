using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2017
{
    public class Day3
    {
        private readonly int _value;

        public Day3(int value)
        {
            _value = value;
        }

        public int Task1()
        {
            var sqrt = (int)Math.Ceiling(Math.Sqrt(_value));
            var maxValue = sqrt * sqrt;
            var minValue = (sqrt - 2) * (sqrt - 2);
            var sideLength = (maxValue - minValue) / 4;

            //Due to symmetric nature the distance of the point and center can be found in the first quadrant as well.
            var minPoint = _value;
            while (!(minPoint < minValue))
                minPoint -= sideLength;
            //Compensate for one iteration too much.
            minPoint += sideLength; 

            var midPoint = minValue + sideLength / 2;
            var offset = Math.Abs(minPoint - midPoint);
            
            return offset + sideLength / 2;
        }
    }
}
