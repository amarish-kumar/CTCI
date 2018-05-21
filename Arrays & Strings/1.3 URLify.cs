using System;

namespace Arrays___Strings
{
    class URLify
    {
        public static void Exec()
        {
            var expected = "Mr%20John%20Smith%20Best";
            var str = "Mr John Smith Best      ";
            int strLen = 18;

            var result = _Encode(str.ToCharArray(), strLen);
            Console.WriteLine(result);
            Console.WriteLine(result == expected);
        }

        private static string _Encode(char[] str, int trueLen)
        {
            int spaceCount = 0;

            for (var i = 0; i < trueLen; i += 1)
                if (str[i] == ' ')
                    spaceCount += 1;


            int index = trueLen + (spaceCount * 2);

            for (var i = trueLen - 1; i >= 0; i -= 1)
                if (str[i] == ' ')
                {
                    str[index - 1] = '0';
                    str[index - 2] = '2';
                    str[index - 3] = '%';
                    index -= 3;
                }
                else
                {
                    str[index - 1] = str[i];
                    index -= 1;
                }

            return string.Join("", str);
        }
    }
}