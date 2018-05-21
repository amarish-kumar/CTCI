using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Arrays___Strings
{
    class Utils
    {
        public static T DeepClone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }

        public static void PrintMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
                Console.WriteLine(string.Join(",", matrix[row]));
        }
    }
}
