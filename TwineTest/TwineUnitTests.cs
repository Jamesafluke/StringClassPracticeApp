using StringClassPractice;

namespace TwineTest
{
    [TestClass]
    public class TwineUnitTests
    {
        [TestMethod]
        public void LengthTest()
        {
            int result;


            char[] chars1 = new char[] { 'a', 'b', };
            Twine twine1 = new Twine(chars1);
            result = twine1.Length();
            Assert.AreEqual(2, result);


            char[] chars2 = new char[0];
            Twine twine2 = new Twine(chars2);
            result = twine2.Length();
            Assert.AreEqual(0, result);


            char[] chars3 = new char[] { 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b', };
            Twine twine3 = new Twine(chars3);
            result = twine3.Length();
            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void ReverseTest()
        {
            char[] chars1 = new char[] { 'a', 'b', };
            char[] expectedResult = new char[] { 'b', 'a', };
            Twine twine1 = new Twine(chars1);
            Assert.IsTrue(twine1.Reverse().SequenceEqual(expectedResult));

            char[] chars2 = new char[] { 'a' };
            expectedResult = new char[] { 'a' };
            Twine twine2 = new Twine(chars2);
            Assert.IsTrue(twine2.Reverse().SequenceEqual(expectedResult));

            char[] chars3 = new char[] { 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'b' };
            expectedResult = new char[] { 'b', 'a', 'a', 'a', 'a', 'a', 'a', 'a' };
            Twine twine3 = new Twine(chars3);
            Assert.IsTrue(twine3.Reverse().SequenceEqual(expectedResult));
        }

        [TestMethod]
        public void IsPalindromeTest()
        {

        }

        [TestMethod]
        public void ToLowerCaseTest()
        {
            char[] chars1 = { 'A', 'B', 'C' };
            char[] expectedResult = { 'a', 'b', 'c' };
            Twine twine1 = new Twine(chars1);
            twine1.ToLowerCase();
            Assert.IsTrue(twine1.CharArray.SequenceEqual(expectedResult));
        }

        [TestMethod]
        public void ToUpperCaseTest()
        {
            char[] chars1 = { 'a', 'b', 'c' };
            char[] expectedResult = { 'A', 'B', 'C' };
            Twine twine1 = new Twine(chars1);
            twine1.ToUpperCase();
            Assert.IsTrue(twine1.CharArray.SequenceEqual(expectedResult));
        }
    }
}