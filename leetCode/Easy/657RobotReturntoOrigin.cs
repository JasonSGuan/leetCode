using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Easy
{
    public class _657RobotReturntoOrigin
    {
        public static bool JudgeCircle(string moves)
        {
            int Lcount = 0;
            int Rcount = 0;
            int Ucount = 0;
            int Dcount = 0;
            foreach (char word in moves.ToCharArray())
            {
                switch (word)
                {
                    case 'L': Lcount++; break;
                    case 'R': Rcount++; break;
                    case 'U': Ucount++; break;
                    case 'D': Dcount++; break;
                }
            }
            if (Lcount == Rcount && Ucount == Dcount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
