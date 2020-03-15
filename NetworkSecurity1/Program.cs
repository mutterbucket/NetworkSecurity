using Confluent.Kafka;
using System;
using System.Linq;

namespace NetworkSecurity1
{
    class Program
    {


        static void Main(string[] args)
        {
            int alphabetIndex;
            int additiveInt = 0;
            string ciphertext;
            string[] plaintext = new string[10];
            int[] alphabetStats = new int[26];
            int[] bruteForce = new int[26];
            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F',
                                'G', 'H', 'I', 'J', 'K', 'L',
                                'M', 'N', 'O', 'P', 'Q', 'R',
                                'S', 'T', 'U', 'V', 'W', 'X',
                                'Y', 'Z' };

            Console.WriteLine("Welcome!\nThis program will decrypt text enciphered with an additive cipher.");

            Console.WriteLine("Please enter your ciphertext: ");

            ciphertext = Console.ReadLine();
            ciphertext = ciphertext.ToUpper();

            Console.WriteLine("Decrypting...");

            char[] letterbyletter = ciphertext.ToCharArray();


            // Count the letter frequency 
            for (int i = 0; i < letterbyletter.Length; i++)
            {
                switch (letterbyletter[i])
                {
                    case 'A':
                        alphabetStats[0]++;
                        break;
                    case 'B':
                        alphabetStats[1]++;
                        break;
                    case 'C':
                        alphabetStats[2]++;
                        break;
                    case 'D':
                        alphabetStats[3]++;
                        break;
                    case 'E':
                        alphabetStats[4]++;
                        break;
                    case 'F':
                        alphabetStats[5]++;
                        break;
                    case 'G':
                        alphabetStats[6]++;
                        break;
                    case 'H':
                        alphabetStats[7]++;
                        break;
                    case 'I':
                        alphabetStats[8]++;
                        break;
                    case 'J':
                        alphabetStats[9]++;
                        break;
                    case 'K':
                        alphabetStats[10]++;
                        break;
                    case 'L':
                        alphabetStats[11]++;
                        break;
                    case 'M':
                        alphabetStats[12]++;
                        break;
                    case 'N':
                        alphabetStats[13]++;
                        break;
                    case 'O':
                        alphabetStats[14]++;
                        break;
                    case 'P':
                        alphabetStats[15]++;
                        break;
                    case 'Q':
                        alphabetStats[16]++;
                        break;
                    case 'R':
                        alphabetStats[17]++;
                        break;
                    case 'S':
                        alphabetStats[18]++;
                        break;
                    case 'T':
                        alphabetStats[19]++;
                        break;
                    case 'U':
                        alphabetStats[20]++;
                        break;
                    case 'V':
                        alphabetStats[21]++;
                        break;
                    case 'W':
                        alphabetStats[22]++;
                        break;
                    case 'X':
                        alphabetStats[23]++;
                        break;
                    case 'Y':
                        alphabetStats[24]++;
                        break;
                    case 'Z':
                        alphabetStats[25]++;
                     
                        break;
                    default: break;
                }
            }

            // Find the top ten most frequently appearing letters
            for (int i = 0; i < 10; i++)
            {
                bruteForce[i] = alphabetStats.ToList().IndexOf(alphabetStats.Max());
                alphabetStats[bruteForce[i]] = 0; // Clear top value to find next highest
            }

            // Print the top ten possible solutions
            for (int j = 0; j < bruteForce.Length; j++)
            {
                // Print each character in the original array shifted relative to E
                for (int i = 0; i < letterbyletter.Length; i++)
                {
                    alphabetIndex = alphabet.ToList().IndexOf(letterbyletter[i]);

                    switch (bruteForce[j])
                    {
                        case 0 : additiveInt = -4;
                            break;
                        case 1: additiveInt = -3;
                            break;
                        case 2: additiveInt = -2;
                            break;
                        case 3: additiveInt = -1;
                            break;
                        case 4: additiveInt = 0;
                            break;
                        case 5: additiveInt = 1;
                            break;
                        case 6: additiveInt = 2;
                            break;
                        case 7: additiveInt = 3;
                            break;
                        case 8: additiveInt = 4;
                            break;
                        case 9: additiveInt = 5;
                            break;
                        case 10: additiveInt = 6;
                            break;
                        case 11: additiveInt = 7;
                            break;
                        case 12: additiveInt = 8;
                            break;
                        case 13: additiveInt = 9;
                            break;
                        case 14: additiveInt = 10;
                            break;
                        case 15: additiveInt = 11;
                            break;
                        case 16: additiveInt = 12;
                            break;
                        case 17: additiveInt = 13;
                            break;
                        case 18: additiveInt = 14;
                            break;
                        case 19: additiveInt = 15;
                            break;
                        case 20: additiveInt = 16;
                            break;
                        case 21: additiveInt = 17;
                            break;
                        case 22: additiveInt = 18;
                            break;
                        case 23: additiveInt = 19;
                            break;
                        case 24: additiveInt = 20;
                            break;
                        case 25: additiveInt = 21;
                            break;
                        default: break;
                    }

                    if ((alphabetIndex + additiveInt) > 25)
                    {
                        alphabetIndex = (alphabetIndex + additiveInt - 26);
                    }
                    else if ((alphabetIndex + additiveInt) < 0)
                    {
                        alphabetIndex = (alphabetIndex + additiveInt + 26);
                    }
                    else
                    {
                        alphabetIndex += additiveInt;
                    }

                    Console.Write(alphabet[alphabetIndex]);

                }
                Console.WriteLine();
            }



        }
    }
}
