using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_S19
{
    public static class TrianglePatternUtil
    {
        public static string GetLeftSideOfLine(int n)
        {
            var ret = string.Empty;

            for (int i = 0; i < n; i++)
            {
                ret = ret + "*";
            }

            return ret;
        }

        public static string GetRightSideOfLine(int n)
        {
            var ret = string.Empty;

            for (int i = 0; i < (n -1); i++)
            {
                ret = ret + "*";
            }

            return ret;
        }

        public static string GetLineIndentation(int lineNum, int totalLine)
        {
            var ret = string.Empty;

            for (int i = lineNum; i < totalLine; i++)
            {
                ret = ret + " ";
            }

            return ret;
        }
    }
}
