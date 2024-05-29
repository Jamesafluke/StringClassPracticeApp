using StringClassPractice;

namespace TwineTest
{
    [TestClass]
    public class CordUnitTests
    {
        [TestMethod]
        public void ToLowerTest()
        {
            Assert.AreEqual(Cord.ToLower("TestING"), "testing");

            Assert.AreEqual(Cord.ToLower("test234ING"), "test234ing");
        }
        
        [TestMethod]
        public void ToUpperTest()
        {
            Assert.AreEqual(Cord.ToUpper("TestING"), "TESTING");
            Assert.AreEqual(Cord.ToUpper("test234ING"), "TEST234ING");
        }

        [TestMethod]
        public void ReverseTest()
        {
            Assert.AreEqual(Cord.Reverse("tesTINg"), "gNITset");
            Assert.AreEqual(Cord.Reverse("23982"), "28932");
        }

        [TestMethod]
        public void IsPalindromeTest()
        {
            Assert.IsTrue(Cord.IsPalindrome("racecar"));
            Assert.IsTrue(Cord.IsPalindrome("1234321"));
            Assert.IsTrue(Cord.IsPalindrome("sdf-1221-fds"));
            Assert.IsTrue(Cord.IsPalindrome("RaCecar"));

            Assert.IsFalse(Cord.IsPalindrome("doink"));
            Assert.IsFalse(Cord.IsPalindrome("12345"));
            Assert.IsFalse(Cord.IsPalindrome("28a@&"));
        }

        [TestMethod]
        public void TrimTest()
        {
            Assert.AreEqual(Cord.Trim("doink", 5, 0), "");
            Assert.AreEqual(Cord.Trim("doink", 0, 6), "");
            Assert.AreEqual(Cord.Trim("doink", 1, 1), "oin");
            Assert.AreEqual(Cord.Trim("doink", 2, 1), "in");
            Assert.AreEqual(Cord.Trim("doink", 4, 0), "k");
            Assert.AreEqual(Cord.Trim("doink", 0, 4), "d");
            Assert.AreEqual(Cord.Trim("doink", 11, 3), "");
            Assert.AreEqual(Cord.Trim("doink", 3, 11), "");
            Assert.AreEqual(Cord.Trim("doink", -1, 0), "doink");
            Assert.AreEqual(Cord.Trim("doink", 0, 0), "doink");

        }

        [TestMethod]
        public void ConvertToCharArrayTest()
        {
            char[] expected = ['0', '1',];
            char[] result = Cord.ConvertToCharArray("01");
            Assert.IsTrue(result.SequenceEqual(expected));

            expected = ['a', 'b', 'c', 'd', 'e'];
            result = Cord.ConvertToCharArray("abcde");
            Assert.IsTrue(result.SequenceEqual(expected));
        }

        [TestMethod]
        public void RemoveNumbersTest()
        {
            Assert.AreEqual(Cord.RemoveNumbers("123abc"),"abc");
            Assert.AreEqual(Cord.RemoveNumbers("123"), "");
            Assert.AreEqual(Cord.RemoveNumbers("1#2$3%a"), "#$%a");
        }

        [TestMethod]
        public void RemoveLettersTest()
        {
            Assert.AreEqual(Cord.RemoveLetters("123abc"), "123");
            Assert.AreEqual(Cord.RemoveLetters("abc"), "");
        }

        [TestMethod]
        public void RemoveCharacterTest()
        {
            Assert.AreEqual(Cord.RemoveCharacter("asdf", 'a'), "sdf");
            Assert.AreEqual(Cord.RemoveCharacter("1234", '4'), "123");
        }

        [TestMethod]
        public void LengthTest()
        {
            Assert.AreEqual(Cord.Length("asdf"), 4);
            Assert.AreEqual(Cord.Length("asdf1234@#$%"), 12);
            Assert.AreEqual(Cord.Length(""), 0);
        }
    }
}
