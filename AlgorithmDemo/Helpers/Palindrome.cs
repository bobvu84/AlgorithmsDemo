using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo.Libs.Helpers
{
    public class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            if (word == null)
            {
                return false;
            }
            if (word == "")
            {
                return true;
            }
            else
            {
                char[] chars = word.ToCharArray();
                int count = chars.Count();
                var numberofChars = (count % 2) == 0 ? count : count - 1;

                for (int i = 0; i <= numberofChars / 2 - 1; i++)
                {
                    if (char.ToLowerInvariant(chars[i]) != char.ToLowerInvariant(chars[count - i - 1]))
                    {
                        return false;
                    }
                }

                return true;
            }

        }
    }
}
