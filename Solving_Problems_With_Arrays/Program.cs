using System.IO.Enumeration;

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

            Console.WriteLine(Encode("Heyhowareyou"));
        }

        private static bool Exercise3_3(int[] array, int arraySize)
        {
            for (var i = 1; i < arraySize; i++)
            {
                if (array[i] < array[i - 1]) return false;
            }
            return true;
        }

        private static string Encode(string plaintext)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string cipherText = "MNBVCXZLKJHGFDSAPOIUYTREWQ";
            plaintext = plaintext.ToUpper();
            char[] codeArray = new char[plaintext.Length];

            for (var i = 0; i < plaintext.Length; i++)
            {
                int cipherIndex = alphabet.IndexOf(plaintext[i]);
                codeArray[i] = cipherText[cipherIndex];
            }

            string code = new string(codeArray);
            return code;
        }

    }                         
}                             