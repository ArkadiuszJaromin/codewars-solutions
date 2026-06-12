using System;

public static class Kata
{
        public static string Solution(string str)
        {
            char[] stringChars = str.ToCharArray();
            Array.Reverse(stringChars);
            string reverse = "";
            foreach (char strChar in stringChars)
            {
                reverse += strChar;
                
            }
            return reverse;
        }
}
