using System.IO.Enumeration;
using System.Text;

namespace Solving_Problems_With_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums1 = { 4,2,2,10 };
            //int[] nums2 = { 4,5,9,10 };
            //Exercise3_3(nums1, nums1.Length); // Expected false
            //Exercise3_3(nums2, nums2.Length); // Expected true
            string decipheredText = Encode("HeyWhatsUp");
            Console.WriteLine(decipheredText);
            string decoded = Decode(decipheredText);
            Console.WriteLine(decoded);

        }

        private static string Encode(string plaintext)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string key = "MNBVCXZLKJHGFDSAPOIUYTREWQ";
            plaintext = plaintext.ToUpper();
            char[] codeArray = new char[plaintext.Length];

            for (var i = 0; i < plaintext.Length; i++)
            {
                int cipherIndex = alphabet.IndexOf(plaintext[i]);
                codeArray[i] = key[cipherIndex];
            }

            string code = new string(codeArray);
            return code;
        }

        private static string Decode(string code)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string key = "MNBVCXZLKJHGFDSAPOIUYTREWQ";
            code = code.ToUpper();
            char[] charArray = new char[code.Length];

            for (var i = 0; i < code.Length; i++)
            {
                int decipherIndex = key.IndexOf(code[i]);
                charArray[i] = alphabet[decipherIndex];
            }

            string decipherCode = new string(charArray);
            return decipherCode;
        }

        private static bool Exercise3_3(int[] array, int arraySize)
        {
            for (var i = 1; i < arraySize; i++)
            {
                if (array[i] < array[i - 1]) return false;
            }

            return true;
        }
    }
}