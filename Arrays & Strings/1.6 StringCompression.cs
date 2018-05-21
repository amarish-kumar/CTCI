using System;
using System.Text;

namespace Arrays___Strings
{
    class StringCompression
    {
        public static void Exec()
        {
            string str = "aabcccccaaa";
            string expected = "a2b1c5a3";

            var result = _Compress(str);

            Console.WriteLine(result + ": " + (result == expected));
        }

        private static string _Compress(string str)
        {
            var sb = new StringBuilder();

            var count = 0;
            var currentChar = str[0];
            foreach (var ch in str)
            {
                if (currentChar == ch)
                {
                    count += 1;
                }
                else
                {
                    sb.Append($"{currentChar}{count}");
                    count = 1;
                    currentChar = ch;
                }
            }
            sb.Append($"{currentChar}{count}");

            return str.Length > sb.Length
                ? sb.ToString()
                : str;
        }
    }
}