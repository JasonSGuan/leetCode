using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Easy
{
    public class _1309DecryptString
    {
        public static string FreqAlphabets(string s)
        {
            string sWord = "";
            for (int i = 0; i < s.Length;)
            {
                if (i + 2 < s.Length)
                {
                    if (s.ToCharArray()[i + 2] == '#')
                    {
                        char word = (char)(96 + Convert.ToInt16(s.Substring(i, 2)));
                        i = i + 3;
                        sWord += word.ToString();
                    }
                    else
                    {
                        char word = (char)(96 + Convert.ToInt16(s.Substring(i, 1)));
                        i = i + 1;
                        sWord += word.ToString();
                    }
                }
                else
                {
                    char word = (char)(96 + Convert.ToInt16(s.Substring(i, 1)));
                    i = i + 1;
                    sWord += word.ToString();
                }
            }
            return sWord;
        }
    }
}
