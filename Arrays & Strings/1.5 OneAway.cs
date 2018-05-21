using System;

namespace Arrays___Strings
{
    class OneAway
    {
        public static void Exec()
        {
            while (true)
            {
                Console.Write("Write a string1: ");
                var str1 = Console.ReadLine();
                if (str1 == string.Empty)
                    break;
                Console.Write("Write a string2: ");
                var str2 = Console.ReadLine();

                Console.WriteLine("One Away: " + _CheckOneAway(str1, str2));
            }
        }

        private static bool _Replace(string str1, string str2)
        {
            var result = true;

            bool foundDiff = false;

            for (var i = 0; i < str1.Length; i += 1)
            {
                if (str1[i] != str2[i])
                {
                    if (foundDiff)
                    {
                        result = false;
                        break;
                    }
                    foundDiff = true;
                }
            }

            return result;
        }
        private static bool _Insert(string str1, string str2)
        {
            bool result = true;

            var index1 = 0;
            var index2 = 0;

            while (index1 < str1.Length &&
                   index2 < str2.Length)
            {
                if (str1[index1] != str2[index2])
                {
                    if (index1 != index2)
                    {
                        result = false;
                        break;
                    }
                    index2 += 1;
                }
                else
                {
                    index1 += 1;
                    index2 += 1;
                }
            }

            return result;
        }

        private static bool _CheckOneAway(string str1, string str2)
        {
            bool result = true;

            if (str1.Length == str2.Length)
            {
                result = _Replace(str1, str2);
            }
            else if (str1.Length + 1 == str2.Length)
            {
                result = _Insert(str1, str2);
            }
            else if (str1.Length - 1 == str2.Length)
            {
                result = _Insert(str2, str1);
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}