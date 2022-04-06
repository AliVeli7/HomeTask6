using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    class Rectangle : Figure
    {
        private int _length;
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
                else
                {
                    Console.WriteLine("reqem o dan boyuk olmalidir");
                }
            }
        }
        private int _width;
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    Console.WriteLine("eqem 0 dan boyuk olmalidir");
                }
            }
        }
        public override void CalcArea()
        {
            Console.WriteLine($"Rectangle Area:{Length*Width}");
        }
    }
}
