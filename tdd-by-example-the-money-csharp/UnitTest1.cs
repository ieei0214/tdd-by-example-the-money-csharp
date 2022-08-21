using System.Linq.Expressions;
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
            var five = Money.dollar(5);
            Expression sum = five.plus(five);
            Bank bank = new Bank();
            Money reduced = bank.reduce(sum, "USD");
            reduced.Should().Be(Money.dollar(10));
        }        
        
        [Test]
        public void testReturnSum()
        {
            var five = Money.dollar(5);
            Expression result = five.plus(five);
            Sum sum = (Sum) result;
            sum.augend.Should().Be(five);
            sum.addend.Should().Be(five);
        }

        [Test]
        public void testReduceSum()
        {
            Expression sum = new Sum(Money.dollar(3), Money.dollar(4));
            Bank bank = new Bank();
            Money result = bank.reduce(sum, "USD");
            result.Should().Be(Money.dollar(7));
        }

        [Test]
        public void testReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.reduce(Money.dollar(1), "USD");
            result.Should().Be(Money.dollar(1));
        }

        [Test]
        public void testReduceMoneyDifferentCurrency()
        {
            var bank = new Bank();
            bank.addRate("CHF", "USD", 2);
            var result = bank.reduce(Money.franc(2), "USD");
            result.Should().Be(Money.dollar(1));
        }

        [Test]
        public void testMixedAddition()
        {
            Expression fiveBucks = Money.dollar(5);
            Expression tenBucks = Money.franc(10);
            Bank bank = new Bank();
            bank.addRate("CHF", "USD", 2);
            bank.reduce(fiveBucks.plus(tenBucks), "USD");

        }

        [Test]
        public void testSumPlusMoney()
        {
            Expression fiveBucks = Money.dollar(5);
            var tenFrancs = Money.franc(10);
            Bank bank = new Bank();
            bank.addRate("CFH", "USD", 2);
            Expression sum = new Sum(fiveBucks, tenFrancs).plus(fiveBucks);
            Money result = bank.reduce(sum,"USD");
            result.Should().Be(Money.dollar(15));
        }
    }
}