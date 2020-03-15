using System;

namespace RC4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the RC4 program!");

            int[] seed = new int[256];
            int j = 0;
            int i = 0;
            int[] key = { 0x8f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff };
            int plaintext = 0xff;
            int swap = 0;
            int t = 0;
            int k = 0;
            int ciphertext = 0;

            // KSA
            for (i = 0; i < 255; i++)
            {
                seed[i] = i;
            }
                

            for (i = 0; i < 255; i++){
                j = ((j + seed[i] + key[i % key.Length]) % 255);
                swap = seed[i];
                seed[i] = seed[j];
                seed[j] = swap;
            }

            i = 0;
            j = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();

            // PSGA
            for (int x = 0; x < 1; x++)
            {
                i = (i + 1) % 256;
                j = (j + seed[i]) % 256;

                swap = seed[i];
                seed[i] = seed[j];
                seed[j] = swap;

                t = ((seed[i] + seed[j]) % 256);
                k = seed[t];

                if (x == 0)
                {
                    ciphertext = plaintext ^ k;
                }
                else
                {
                    ciphertext = ciphertext ^ k;
                }

                Console.Write(ciphertext + " ");
            }
            
            watch.Stop();
            //Console.WriteLine("\nElapsed time: " + watch.ElapsedMilliseconds);
        }
    }
}
