using System;

namespace Arrays___Strings
{
    class StringRotation
    {
        public static void Exec()
        {
            var str1 = "waterbotle";
            var str2 = "otlewaterb";


            var strDouble = str1 + str1;
            Console.WriteLine($"Is Rotation: {strDouble.Contains(str2)}");
        }
    }
}