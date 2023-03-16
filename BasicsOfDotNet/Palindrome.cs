using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfDotNet
{
    internal class Palindrome
    {
        public string CreatePalindrome(string s)
        {
            char[] arr=s.ToCharArray();

            int l = s.Length;
            /*
            for (int i = 0; i < l; i++)
            {

               Console.WriteLine(arr[i]);

            }
            */

            for (int i=0;i<l/2;i++)
            {

                char t = arr[i];
                arr[i] = arr[l - 1- i];
                arr[l - 1-i] = t;
                
            }
            string temp= new string(arr);
            return temp;
        }

        public void CheckPalindrome(string s1, string s2)
        {
            if (s1 == s2)
            {
                Console.WriteLine("The given string is Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
