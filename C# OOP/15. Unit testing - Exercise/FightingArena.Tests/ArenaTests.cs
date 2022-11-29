namespace FightingArena.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Extensions.DependencyModel.Resolution;
    using NUnit.Framework;

    [TestFixture]
    public class ArenaTests
    {
        private Arena arena;
        private Warrior attacker;
        private Warrior defender;

        [SetUp]
        public void SetUp()
        {
           this.arena = new Arena();
           this.attacker = new Warrior("Gosho", 50, 50);
           this.defender = new Warrior("Pesho", 40, 80);
        }

        [Test]
        public void ConstructorShouldInitializeWarriorCollectionProperly()
        {
            var constructorArena = new Arena();
            Assert.IsNotNull(constructorArena);
        }

        [Test]
        public void WarriorCollectionShouldBeReadOnly()
        {
            Assert.IsInstanceOf<IReadOnlyCollection<Warrior>>(this.arena.Warriors);
        }

        [Test]
        public void CountShouldReturnCorrectCount()
        {
            var expectedCount = 0;
            var actualCount = this.arena.Count;
                
           Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void EnrollShouldAddUniqueWarriorsToTheList()
        {
            arena.Enroll(this.attacker);
            
            Assert.True(arena.Warriors.Contains(this.attacker));
        }

        [Test] 
        public void EnrollShouldIncreaseCount()
        {
            this.arena.Enroll(this.attacker);
            this.arena.Enroll(this.defender);

            var expectedCount = 2;
            var actualCount = this.arena.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void EnrollShouldThrowAnExceptionWhenEnrollExistingWarrior()
        {
            this.arena.Enroll(attacker);

            Assert.Throws<InvalidOperationException>(() => this.arena.Enroll(attacker));
        }

        [Test]
        public void EnrollShouldThrowAnExceptionWhenEnrollWarriorWithExistingName()
        {
            this.arena.Enroll(new Warrior("Gerasim", 30, 60));

            Assert.Throws<InvalidOperationException>(() => 
                this.arena.Enroll(new Warrior("Gerasim", 35, 60)));
        }

        [Test]
        public void FightShouldInvokeAttackMethodWhenBothWarriorsExist()
        {
            this.arena.Enroll(attacker);
            this.arena.Enroll(defender);

            this.arena.Fight("Gosho", "Pesho");

            var expectedAttackerHP = 10;
            var expectedDefenderHP = 30;

            var actualAttackerHP = attacker.HP;
            var actualDefenderHP = defender.HP;

            Assert.AreEqual(expectedAttackerHP, actualAttackerHP);
            Assert.AreEqual(expectedDefenderHP, actualDefenderHP);
        }

        [Test]
        public void FightShouldThrowAnExceptionWithNonExistingAttacker()
        {
            this.arena.Enroll(attacker);
            this.arena.Enroll(defender);

            Assert.Throws<InvalidOperationException>(() => 
                this.arena.Fight("Sasho", "Pesho"));
        }

        [Test]
        public void FightShouldThrowAnExceptionWithNonExistingDefender()
        {
            this.arena.Enroll(attacker);
            this.arena.Enroll(defender);

            Assert.Throws<InvalidOperationException>(() => 
                this.arena.Fight("Gosho", "Plamen"));
        }

        [Test]
        public void FightShouldThrowAnExceptionWithNonExistingWarriors()
        {
            this.arena.Enroll(attacker);
            this.arena.Enroll(defender);

            Assert.Throws<InvalidOperationException>(() => 
                this.arena.Fight("Ganyo", "Plamen"));
        }
    }
}
