using System;

namespace LongestPalindromeSubstring
{
    public class LongestPalindrome 
    {
        public string getLongestPalindrome(string data) {
            string longestPalindrome = "";
            for (int i = 0; i < data.Length-1; i++)
            {
                string digit1 = data[i].ToString()+data[i+1];
                string digit2 = data[i+1].ToString()+data[i].ToString();
                if (digit1 == digit2) {
                    longestPalindrome = digit1;
                }
            }
            if (longestPalindrome == "") {
                for (int i = 0; i < data.Length-2; i++)
                {
                    string digit1 = data[i].ToString()+data[i+1].ToString()+data[i+2].ToString();
                    string digit2 = data[i+2].ToString()+data[i+1].ToString()+data[i].ToString();
                    if (digit1 == digit2) {
                        longestPalindrome = digit1;
                    }
                }
            }
            return longestPalindrome;
        }
    }
}