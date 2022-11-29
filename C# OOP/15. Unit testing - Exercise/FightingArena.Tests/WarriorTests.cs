namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;


    [TestFixture]
    public class WarriorTests
    {
        [Test]
        public void ConstructorShouldInitializeDataProperly()
        {
            var warrior = new Warrior("Pesho", 30, 30);

            Assert.AreEqual("Pesho", warrior.Name);
            Assert.AreEqual(30, warrior.Damage);
            Assert.AreEqual(30, warrior.HP);
        }

        [TestCase("")]
        [TestCase("     ")]
        [TestCase(null)]
        public void NameSetterShouldThrowAnExceptionWhenValueIsNullOrEmpty(string name)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, 30, 30));
        }

        [TestCase(0)]
        [TestCase(-10)]
        public void DamageSetterShouldThrowAnExceptionWithIsZeroOrNegativeDamage(int damage)
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Pesho", damage, 30));
        }

        
        [TestCase(-10)]
        public void HPSetterShouldThrowAnExceptionWithNegativeHP(int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Pesho", 30, hp));
        }

        [Test]
        public void BothWarriorsShouldTakeDamageWhenAttackEachOther()
        {
            var attackerDamage = 30;
            var attackerHP = 50;

            var defenderDamage = 35;
            var defenderHP = 40;

            var attacker = new Warrior("Gosho", attackerDamage, attackerHP);
            var defender = new Warrior("Pesho", defenderDamage, defenderHP);

            attacker.Attack(defender);

            var expectedAttackerHP = attackerHP - defenderDamage;
            var expectedDefenderHP = defenderHP - attackerDamage;
            
            Assert.AreEqual(expectedAttackerHP, attacker.HP);
            Assert.AreEqual(expectedDefenderHP, defender.HP);
        }

        [Test]
        public void WarriorShouldTakeDamageWhenAttackEnemyAndIfEnemyWarriorDieHisHPShouldBeZero()
        {
            var attackerDamage = 50;
            var attackerHP = 50;
            var defenderDamage = 35;
            var defenderHP = 40;

            var attacker = new Warrior("Gosho", attackerDamage, attackerHP);
            var defender = new Warrior("Pesho", defenderDamage, defenderHP);

            attacker.Attack(defender);

            var expectedAttackerHp = attackerHP - defenderDamage;
            var expectedDefenderHp = 0;

            Assert.AreEqual(expectedAttackerHp, attacker.HP);
            Assert.AreEqual(expectedDefenderHp, defender.HP);
        }

        [Test]
        public void AttackShouldThrowAnExceptionWhenAttackerHasLowerThanMinAttackHP()
        {
            var attackerDamage = 50;
            var attackerHP = 20;
            var defenderDamage = 35;
            var defenderHP = 40;

            var attacker = new Warrior("Gosho", attackerDamage, attackerHP);
            var defender = new Warrior("Pesho", defenderDamage, defenderHP);

            Assert.Throws<InvalidOperationException>(() => attacker.Attack(defender));
        }

        [Test]
        public void AttackShouldThrowAnExceptionWhenDefenderHasLowerThanMinAttackHP()
        {
            var attackerDamage = 50;
            var attackerHP = 50;
            var defenderDamage = 35;
            var defenderHP = 25;

            var attacker = new Warrior("Gosho", attackerDamage, attackerHP);
            var defender = new Warrior("Pesho", defenderDamage, defenderHP);

            Assert.Throws<InvalidOperationException>(() => attacker.Attack(defender));
        }

        [Test]
        public void AttackShouldThrowAnExceptionWhenAttackerHPIsLowerThanDefenderDamage()
        {
            var attackerDamage = 50;
            var attackerHP = 32;
            var defenderDamage = 35;
            var defenderHP = 35;

            var attacker = new Warrior("Gosho", attackerDamage, attackerHP);
            var defender = new Warrior("Pesho", defenderDamage, defenderHP);

            Assert.Throws<InvalidOperationException>(() => attacker.Attack(defender), "You are trying to attack too strong enemy");
        }
    }
}