using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            int Uppercase = 65;
            int Lowercase = 97;

            string Cipher = "";

            foreach(char c in text)
            {
                if(char.IsUpper(c))
                {
                    int a = (int)c - Uppercase + shiftKey;
                    a %= 26;
                    a += Uppercase;
                    Cipher += (char)a;
                }
                else if(char.IsLower(c))
                {
                    int a = (int)c - Lowercase + shiftKey;
                    a %= 26;
                    a += Lowercase;
                    Cipher += (char)a;
                }
                else
                {
                    Cipher += c;
                }
            }
            return Cipher;
        }
    }
}
