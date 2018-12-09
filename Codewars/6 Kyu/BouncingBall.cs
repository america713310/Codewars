using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class BouncingBall
    {
        static int _count = 0;
        public static int BouncingBallCount(double h, double bounce, double window)
        {
            if (bounce >= 1 || h < 0 || bounce < 0 || window < 0 || h == window)
            {
                return -1;
            }
            double height = h * bounce;
            if (height <= window)
            {
                int _result = _count + 1;
                _count = 0;
                return _result;
            }
            _count += 2;
            return BouncingBallCount(height, bounce, window);
        }
    }
}
