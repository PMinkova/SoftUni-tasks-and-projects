namespace Skeleton.Tests
{
    using System;

    using NUnit.Framework;

    [TestFixture]
    public class DummyTests
    {
        private const int ALIVE_DUMMY_HEALTH = 10;
        private const int DEAD_DUMMY_HEALT = 0;
        private const int DUMMY_EXPERIENCE = 10;
        private const int ATTACK_POINTS = 5;

        private Dummy aliveDummy;
        private Dummy deadDummy;

        [SetUp]
        public void SetDummy()
        {
            aliveDummy = new Dummy(ALIVE_DUMMY_HEALTH, DUMMY_EXPERIENCE);
            deadDummy = new Dummy(DEAD_DUMMY_HEALT, DUMMY_EXPERIENCE);
        }

        [Test]
        public void DummyShouldLooseHealthWhenTakeAttack()
        {
            aliveDummy.TakeAttack(ATTACK_POINTS);
            var expectedDummyHealth = 5;
            Assert.That(this.aliveDummy.Health, Is.EqualTo(expectedDummyHealth), "Dummy Health doesn`t change after attack.");
        }

        [Test]
        public void DeadDummyShouldThrowExceptionIfAttacked()
        {
            Assert.Throws<InvalidOperationException>(() => 
                this.deadDummy.TakeAttack(ATTACK_POINTS), "Dummy is dead.");
            
        }

        [Test]
        public void DeadDummyCanGiveExperience()
        {
            var actualExperience = this.deadDummy.GiveExperience();
            var expectedExperience = 10;

            Assert.That(actualExperience, Is.EqualTo(expectedExperience), "Dead dummy can`t give experience.");
        }

        [Test]
        public void AliveDummyCannotGiveExperience()
        {
            Assert.Throws<InvalidOperationException>(() => 
                this.aliveDummy.GiveExperience(), "Target is not dead.");
        }
    }
}