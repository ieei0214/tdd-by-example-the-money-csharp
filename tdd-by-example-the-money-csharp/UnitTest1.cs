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
            Money five = Money.dollar(5);
            five.times(2).Should().Be(Money.dollar(10));
            five.times(3).Should().Be(Money.dollar(15));
        }

        [Test]
        public void testEquality()
        {
            Money.dollar(5).Should().Be(Money.dollar(5));
            Money.dollar(5).Should().NotBe(Money.dollar(6));
            Money.franc(5).Should().Be(Money.franc(5));
            Money.franc(5).Should().NotBe(Money.franc(6));
            Money.franc(5).Should().NotBe(Money.dollar(5));
        }

        [Test]
        public void testFrancMultiplication()
        {
            var five = Money.franc(5);
            five.times(2).Should().Be(Money.franc(10));
            five.times(3).Should().Be(Money.franc(15));
        }
    }
}