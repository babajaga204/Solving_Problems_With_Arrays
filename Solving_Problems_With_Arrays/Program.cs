using System;
using System.IO.Enumeration;
using System.Runtime.ExceptionServices;
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
            //string decipheredText = Encode("HeyWhatsUp");
            //Console.WriteLine(decipheredText);
            //string decoded = Decode(decipheredText);
            //Console.WriteLine(decoded);

            EncryptAlgo(true, "hey hva skjer");
            EncryptAlgo(false, "LCW LTM IHJCO");

        }

        private static void EncryptAlgo(bool encrypt, string plaintext)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string key = "MNBVCXZLKJHGFDSAPOIUYTREWQ";
            var ciphertext = Encrypt(plaintext, 
                encrypt ? alphabet : key,
                encrypt ? key : alphabet);

            Console.WriteLine(ciphertext);
        }


        private static string Encrypt(string plaintext, string alphabet, string key)
        {
            var ciphertext = "";
            for (int i = 0; i < plaintext.Length; i++)
            {
                ciphertext += EncryptChar(plaintext[i], alphabet, key);
            }
            return ciphertext;
        }

        private static char EncryptChar(char c, string alphabet, string key)
        {

            for (var i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == char.ToUpper(c))
                {
                    return key[i];

                }
            }

            return c;
        }

        private static string CreateKey(string alphabet)
        {
            var key = alphabet.ToCharArray();
            var random = new Random();

            for (int i = 0; i < alphabet.Length; i++)
            {
                int randIndex2;
                int avoidIndex2;

                do
                {
                    var randomChar1 = key[i];
                    var avoidIndex1 = alphabet.IndexOf(randomChar1);
                    randIndex2 = random.Next(0, alphabet.Length - 1);
                    if (randIndex2 >= avoidIndex1) randIndex2++;
                    var randomChar2 = key[randIndex2];
                    avoidIndex2 = alphabet.IndexOf(randomChar2);
                } while (avoidIndex2 == i);
                (key[i], key[randIndex2]) = (key[randIndex2], key[i]);
            }
            return new string(key);
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