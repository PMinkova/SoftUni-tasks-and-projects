namespace Skeleton.Tests
{
    using System;

    using NUnit.Framework;

    [TestFixture]
    public class AxeTests
    {
        private const string AXE_DURABILITY_RESULT_FAILED_MESSAGE = "Axe Durability doesn`t change after attack.";
        private const string AXE_BROKEN_MESSAGE = "Axe is broken.";

        private const int DUMMY_HEALTH = 10;
        private const int ATTACK_POINTS = 10;

        private Dummy dummy;

        [SetUp]
        public void SetDummy()
        {
            dummy = new Dummy(DUMMY_HEALTH, 10);
        }

        [Test]
        public void AxeShouldLooseDurabilityAfterAttack()
        {
            var axe = new Axe(ATTACK_POINTS, 10);
            axe.Attack(this.dummy);

            Assert.That(axe.DurabilityPoints, Is.EqualTo(9), AXE_DURABILITY_RESULT_FAILED_MESSAGE);
        }

        [Test]
        public void AxeShouldThrowExceptionWhenAttackWithBrokenWeapon()
        {
            var axe = new Axe(ATTACK_POINTS, 0);
            Assert.Throws<InvalidOperationException>(() => axe.Attack(this.dummy), AXE_BROKEN_MESSAGE);
        }
    }
}