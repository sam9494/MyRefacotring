using NUnit.Framework;

namespace MyRefactoring
{
    [TestFixture]
    public class ChangeMethodTest
    {
        [Test]
        public void should_call_old_method()
        {
            var changeMethod = new ChangeMethod();
            var expert= "This is New Method";
            var actual= changeMethod.NewMethod();
            Assert.AreEqual(expert,actual);
        }

        [Test]
        public void should_call_new_method()
        {
            var changeMethod = new ChangeMethod();
            var expert= "This is New Method";
            var actual = changeMethod.NewMethod();
            Assert.AreEqual(expert,actual);
        }
    }
}