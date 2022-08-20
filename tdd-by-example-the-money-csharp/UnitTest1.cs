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
            Money.franc(5).Should().NotBe(Money.dollar(5));
        }

        [Test]
        public void testFrancMultiplication()
        {
            var five = Money.franc(5);
            five.times(2).Should().Be(Money.franc(10));
            five.times(3).Should().Be(Money.franc(15));
        }

        [Test]
        public void testCurrency()
        {
            Money.dollar(1).currency().Should().Be("USD");
            Money.franc(1).currency().Should().Be("CHF");
        }

        [Test]
        public void testSimpleAddition()
        {
            Money sum = Money.dollar(5).plus(Money.dollar(5));
            sum.Should().Be(Money.dollar(10));
            Money reduced = bank.reduce(sum, "USD");
            reduced.Should().Be(Money.dollar(10));
        }
    }
}