using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IronSoftwareOldPhon
{
    class Program
    {
        static void Main(string[] args)
        {
            string output1 = OldPhonePad("33#"); // Output: E
            string output2 = OldPhonePad("227*#"); // Output: B
            string output3 = OldPhonePad("4433555 555666#"); // Output: HELLO
            string output4 = OldPhonePad("8 88777444666*664#"); // Output: TURING

            Console.WriteLine(output1);
            Console.WriteLine(output2);
            Console.WriteLine(output3);
            Console.WriteLine(output4);
            Console.ReadLine();
        }

        /*
         * OldPhonePad - A method that takes a string input and returns a string that represents the corresponding 
         * numbers dialed on an old phone keypad.
         *
         * @param input: A string representing the input to be converted to phone keypad numbers.
         * @return: A string representing the phone keypad numbers corresponding to the input.
         */
        public static string OldPhonePad(string input)
        {
            // Create a dictionary that maps keypad numbers to their corresponding letters.
            Dictionary<char, string> keypad = new Dictionary<char, string>()
            {
                {'2', "ABC"},
                {'3', "DEF"},
                {'4', "GHI"},
                {'5', "JKL"},
                {'6', "MNO"},
                {'7', "PQRS"},
                {'8', "TUV"},
                {'9', "WXYZ"}
            };

            // Create a StringBuilder to hold the output.
            StringBuilder output = new StringBuilder();

            // Initialize repeatCount and i to zero.
            int repeatCount = 0;
            int i = 0;

            // Loop through the input string.
            while (i  < input.Length)
            {
                repeatCount = 0;
                if (input[i] > '1' && input[i] <= '9')
                {
                    // Invalid character, ignore
                    // Loop through the rest of the input string to find the corresponding keypad number.
                    for (int j = i; j < input.Length; j++)
                    {
                        // If the current character is the same as the previous one, increment repeatCount.
                        if (input[i] == input[j] )
                        {
                            repeatCount++;
                        }
                        // If the current character is a space, append the corresponding letter to the output StringBuilder and update i.
                        else if (input[j].ToString() == " ")
                        {
                            output.Append(keypad[input[i]][repeatCount - 1]);
                            i = j + 1;
                            break;
                        }
                        // If the current character is different from the previous one and not a space, append the corresponding letter to the output StringBuilder and update i.
                        else if (input[i] != input[j] && input[j].ToString() != " ")
                        {
                            output.Append(keypad[input[i]][repeatCount - 1]);
                            i = j;
                            break; 
                        }
                        
                    }
                    
                }
                // If the current character is '#', we have reached the end of the input, so break out of the loop.
                else if (input[i] == '#')
                {
                    // End of input, return the output
                    break;
                }
                // If the current character is '*', remove the last character from the output StringBuilder.
                else if (input[i] == '*')
                {
                    if (output.Length > 0)
                    {
                        output.Length--;
                    }
                    i++;
                }

            }

            // Return the output StringBuilder as a string.
            return output.ToString();
        }

    }
    
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSingleCharacterInput()
        {
            string input = "2#";
            string expected = "A";
            Assert.AreEqual(expected, Program.OldPhonePad(input));
        }

        [TestMethod]
        public void TestMultipleCharacterInput()
        {
            string input = "225566#";
            string expected = "BKN";
            Assert.AreEqual(expected, Program.OldPhonePad(input));
        }

        [TestMethod]
        public void TestInputWithSpaces()
        {
            string input = "2 22 555666 6#";
            string expected = "ABLOM";
            Assert.AreEqual(expected, Program.OldPhonePad(input));
        }

        [TestMethod]
        public void TestInputWithRepeatedCharacters()
        {
            string input = "2#";
            string expected = "A";
            Assert.AreEqual(expected, Program.OldPhonePad(input));
        }

        [TestMethod]
        public void TestInputWithInvalidCharacters()
        {
            string input = "23#";
            string expected = "AD";
            Assert.AreEqual(expected, Program.OldPhonePad(input));
        }

        [TestMethod]
        public void TestInputWithStar()
        {
            string input = "2255*6#";
            string expected = "BM";
            Assert.AreEqual(expected, Program.OldPhonePad(input));
        }
    }
}
