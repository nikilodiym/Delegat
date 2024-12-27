namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string message = "Hello, World!";
            string expectedOutput = "HELLO, WORLD!";

            string actualOutput = DisplayMessageInUppercase(message);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        private string DisplayMessageInUppercase(string message)
        {
            return message.ToUpper();
        }
    }
}