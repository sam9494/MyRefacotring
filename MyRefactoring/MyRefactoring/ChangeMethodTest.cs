using NUnit.Framework;

namespace MyRefactoring
{
    [TestFixture]
    public class ChangeMethodTest
    {
        [Test]
        public void should_call_new_method()
        {
            var changeMethod = new ChangeMethod();
            var expert= "This is Old Method";
            var actual= changeMethod.OldMethod();

            Assert.AreEqual(expert,actual);

        }
    }
}