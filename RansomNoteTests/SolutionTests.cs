namespace RansomNoteTests
{
    using RansomNote;

    public class SolutionTests
    {

        [Test]
        [TestCase("", "a")]
        [TestCase("", "bbb")]
        public void CanConstruct_withEmptyRansomNoteForAnyMagazine_returnsTrue(string ransomNote, string magazine)
        {
            Assert.IsTrue(Solution.CanConstruct(ransomNote, magazine), "The result was fañse");
        }

        [Test]
        [TestCase("a", "")]
        [TestCase("ab", "")]
        public void CanConstruct_withEmptyMagazineForAnyRansomNote_returnsFalse(string ransomNote, string magazine)
        {
            Assert.IsFalse(Solution.CanConstruct(ransomNote, magazine), "The result was true");
        }

        [Test]
        [TestCase("a", "b")]
        [TestCase("abc", "abe")]
        [TestCase("abc", "def")]
        public void CanConstruct_withRansomsNotContainedInMagazine_returnsFalse(string ransomNote, string magazine)
        {
            Assert.IsFalse(Solution.CanConstruct(ransomNote, magazine), "The result was true");
        }

        [Test]
        [TestCase("", "")]
        [TestCase("a", "a")]
        [TestCase("b", "b")]
        [TestCase("aaa", "aaa")]
        [TestCase("bbb", "bbb")]
        [TestCase("ababa", "ababa")]
        public void CanConstruct_withSameInputs_returnsTrue(string ransomNote, string magazine)
        {
            Assert.IsTrue(Solution.CanConstruct(ransomNote, magazine), "The result was false");
        }

        [Test]
        [TestCase("a", "abcd")]
        [TestCase("b", "abcd")]
        [TestCase("c", "abcd")]
        [TestCase("d", "abcd")]
        [TestCase("ab", "abcd")]
        [TestCase("abc", "abcd")]
        [TestCase("bc", "abcd")]
        [TestCase("bcd", "abcd")]
        [TestCase("cd", "abcd")]
        public void CanConstruct_withASingleLetterContainedInMagazine_returnsTrue(string ransomNote, string magazine)
        {
            Assert.IsTrue(Solution.CanConstruct(ransomNote, magazine), "The result was false");
        }

        [Test]
        [TestCase("aa", "abbb")]
        public void CanConstruct_withRansomWithNotEnoughLettersInMagazine_returnsFalse(string ransomNote, string magazine)
        {
            Assert.IsFalse(Solution.CanConstruct(ransomNote, magazine), "The result was true");
        }
    }
}