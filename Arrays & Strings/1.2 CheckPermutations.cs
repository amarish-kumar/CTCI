using System;
using System.Linq;

namespace Arrays___Strings
{
    class CheckPermutations
    {
        public static void Exec()
        {
            Console.Write("Str1: ");
            var str1 = Console.ReadLine().ToLower();

            Console.Write("Str2: ");
            var str2 = Console.ReadLine().ToLower();

            Console.WriteLine(_Compare(str1, str2) && _CompareEfficient(str1, str2));
        }

        private static bool _CompareEfficient(string str1, string str2)
        {
            var result = true;

            if (str1.Length != str2.Length)
            {
                result = false;
            }
            else
            {
                var letters = new int[256];

                foreach (var ch in str1)
                    letters[ch] += 1;
                
                foreach (var ch in str2)
                {
                    letters[ch] -= 1;

                    if (letters[ch] < 0)
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        private static bool _Compare(string str1, string str2)
        {
            var result = true;

            if (str1.Length != str2.Length)
            {
                result = false;
            }
            else
            {
                str1 = string.Join("", str1.OrderBy(s => s));
                str2 = string.Join("", str2.OrderBy(s => s));

                if (str1 != str2)
                    result = false;
            }

            return result;
        }
    }
}
