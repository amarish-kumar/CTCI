using System;

namespace Arrays___Strings
{
    class PalindromePermutation
    {
        public static void Exec()
        {
            string str = "tactcoapapa";

            var table = _BuildCharTable(str.ToLower());

            var result = _CheckMaxOneOdd(table);

            Console.WriteLine(result);
        }

        private static bool _CheckMaxOneOdd(int[] table)
        {
            bool found = false;

            foreach (var count in table)
                if (count % 2 != 0)
                {
                    if (found)
                        return false;

                    found = true;
                }

            return true;
        }

        private static int[] _BuildCharTable(string str)
        {
            var table = new int[26];
            var diff = (int)'a';

            foreach (var ch in str)
                if (ch >= 'a' && ch <= 'z')
                    table[ch - diff] += 1;

            return table;
        }
    }
}
