using System;
using System.Linq;

namespace ConsoleCase
{
    public static class ConsoleExtensions
    {
        public static void Log(this object objectToLog) => Console.WriteLine(objectToLog);

        public static string BytesToString(this byte[] bytes) => BitConverter.ToString(bytes).Replace("-", "");

        public static byte[] StringToByteArray(this string hex)
        {
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
        }
    }
}