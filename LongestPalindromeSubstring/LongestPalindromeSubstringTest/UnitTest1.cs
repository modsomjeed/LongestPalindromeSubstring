using System;
using Xunit;
using LongestPalindromeSubstring;

namespace LongestPalindromeSubstringTest
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            var controller = new LongestPalindrome();
            var result = controller.getLongestPalindrome("babcd");
            Assert.Equal("bab", result);
        }

        [Fact]
        public void Test2()
        {
            var controller = new LongestPalindrome();
            var result = controller.getLongestPalindrome("cbbd");
            Assert.Equal("bb", result);
        }

        [Fact]
        public void Test3()
        {
            var controller = new LongestPalindrome();
            var result = controller.getLongestPalindrome("fabad");
            Assert.Equal("aba", result);
        }
    }
}
