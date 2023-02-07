using Core;
using Shouldly;

namespace UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Class1 c = new Class1();
            c.ShouldNotBeNull();
        }
    }
}