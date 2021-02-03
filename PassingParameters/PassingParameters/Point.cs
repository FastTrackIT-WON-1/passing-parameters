using System;

namespace PassingParameters
{
    public struct Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public readonly void Print()
        {
            Console.WriteLine($"Point at coords X={X}, Y={Y}");
        }
    }
}
