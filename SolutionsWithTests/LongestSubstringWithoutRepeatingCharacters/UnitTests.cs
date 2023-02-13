using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.LongestSubstringWithoutRepeatingCharacters
{
    public class UnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var searchedString = "abcabcbb";
            var expected = 3;

            var result = new Solution()
                .LengthOfLongestSubstring(searchedString);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test2RepeatedCharacterB()
        {
            var searchedString = "bbbbb";
            var expected = 1;

            var result = new Solution()
                .LengthOfLongestSubstring(searchedString);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test3()
        {
            var searchedString = "pwwkew";
            var expected = 3;

            var result = new Solution()
                .LengthOfLongestSubstring(searchedString);

            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
