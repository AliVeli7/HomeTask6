using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    class Square : Figure
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
        public override void CalcArea()
        {
            Console.WriteLine($"Square Area:{Length*Length}");
        }
    }
}
