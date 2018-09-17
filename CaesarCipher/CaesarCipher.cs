using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            //Assigning ASCII values to variables
            int Uppercase = 65;
            int Lowercase = 97;

            // Creating a New string to return
            string Cipher = "";

            // Loop to read all characters in string
            foreach(char c in text)
            {
                // UpperCase Letters
                if(char.IsUpper(c))
                {
                    int a = (int)c - Uppercase + shiftKey;
                    a %= 26;
                    a += Uppercase;
                    Cipher += (char)a;
                }
                // LowerCase Letters
                else if(char.IsLower(c))
                {
                    int a = (int)c - Lowercase + shiftKey;
                    a %= 26;
                    a += Lowercase;
                    Cipher += (char)a;
                }
                // Other Characters
                else
                {
                    Cipher += c;
                }
            }
            return Cipher;
        }
    }
}
