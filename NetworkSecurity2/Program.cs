using System;
using System.Linq;

namespace NetworkSecurity2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F',
                                'G', 'H', 'I', 'J', 'K', 'L',
                                'M', 'N', 'O', 'P', 'Q', 'R',
                                'S', 'T', 'U', 'V', 'W', 'X',
                                'Y', 'Z' };
            string plaintext;
            string key;

            Console.WriteLine("Welcome to the block cipher!");

            Console.WriteLine("Enter your plaintext:");

            plaintext = Console.ReadLine();
            plaintext = plaintext.ToUpper();

            Console.WriteLine("Enter your 5 character key:");

            key = Console.ReadLine();
            key = key.ToUpper();

            char[] plain = plaintext.ToCharArray();

            char[] keys = key.ToCharArray();

            var keyAlpha = keys.Concat(alphabet);

            char[] cipher = keyAlpha.Distinct().ToArray();

            char[] ciphertext = new char[plain.Length];

            for (int i = 0; i < plain.Length; i++)
            {
                ciphertext[i] = cipher[alphabet.ToList().IndexOf(plain[i])];
                Console.Write(ciphertext[i]);
            }

            Console.WriteLine("Now to decrypt: ");

            for (int i = 0; i < plain.Length; i++)
            {
                plain[i] = alphabet[cipher.ToList().IndexOf(ciphertext[i])];
                Console.Write(plain[i]);
            }

        }
    }
}
