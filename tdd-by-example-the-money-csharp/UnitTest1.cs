using System.Runtime.Intrinsics.X86;
using FluentAssertions;

namespace tdd_by_example_the_money_csharp
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void testMultiplication()
        {
            var five = new Dollar(5);
            Dollar product = five.times(2);
            product.Should().Be(new Dollar(10));
            product = five.times(3);
            product.Should().Be(new Dollar(15));
        }

        [Test]
        public void testEquality()
        {
            new Dollar(5).Should().Be(new Dollar(5));
            new Dollar(5).Should().NotBe(new Dollar(6));
        }
    }
}