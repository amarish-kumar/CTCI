using System;

namespace Arrays___Strings
{
    class IsUnique
    {
        public static void Exec()
        {
            while (true)
            {
                Console.WriteLine("Enter a string:");
                Console.Write("--");
                var str = Console.ReadLine();

                if (str == string.Empty)
                    break;

                Console.Write("--");
                Console.WriteLine(_Check(str));
                Console.WriteLine();
            }
        }

        private static bool _Check(string str)
        {
            if (str.Length > 128)
                return false;

            var map = new bool[256];

            for (var i = 0; i < str.Length; i += 1)
            {
                var val = str[i];

                if (map[val])
                    return false;

                map[val] = true;
            }

            return true;
        }
    }
}
