using System;

using NUnit.Framework;

public class HeroRepositoryTests
{
    private HeroRepository heroes;

    [SetUp]
    public void SetUp()
    {
        this.heroes = new HeroRepository();
    }

    [Test]
    public void ConstructorShouldInitializeHeroRepositoryProperly()
    {
        HeroRepository heroRepository = new HeroRepository();
        Assert.IsNotNull(heroRepository);
    }


    [Test]
    public void CreateShouldAddHeroToTheRepository()
    {
        var hero = new Hero("Pesho", 10);
        
        var expectedResult = $"Successfully added hero Pesho with level 10";
        var actualResult = this.heroes.Create(hero);

        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void CreateShouldThrowAnExceptionForInvalidHero()
    {
        Assert.Throws<ArgumentNullException>(() 
            => this.heroes.Create(null));
    }

    [Test]
    public void CreateShouldThrowAnExceptionForExistingName()
    {
        var hero = new Hero("Pesho", 10);
        this.heroes.Create(hero);

        Assert.Throws<InvalidOperationException>(() 
            => this.heroes.Create(new Hero("Pesho", 20)));
    }

    [Test]
    public void RemoveShouldReturnTrueForSuccessfulHeroRemoval()
    {
        var hero = new Hero("Pesho", 10);
        this.heroes.Create(hero);

        Assert.True(this.heroes.Remove("Pesho"));
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase("   ")]
    public void RemoveShouldThrowAnExceptionForNullOrWhiteSpaceName(string name)
    {
        Assert.Throws<ArgumentNullException>(() => this.heroes.Remove(name));
    }

    [Test]
    public void GetHeroWithHighestLevelShouldWorkProperly()
    {
        var heroOne = new Hero("Pesho", 10);
        var heroTwo = new Hero("Niki", 20);

        this.heroes.Create(heroOne);
        this.heroes.Create(heroTwo);

        var expectedHero = heroTwo;
        var actualHero = this.heroes.GetHeroWithHighestLevel();

        Assert.AreEqual(expectedHero, actualHero);
    }

    [Test]
    public void GetHeroShouldReturnTheCorrectHero()
    {
        var hero = new Hero("Pesho", 10);
        this.heroes.Create(hero);

        var expectedHero = hero;
        var actualHero = this.heroes.GetHero("Pesho");

        Assert.AreEqual(expectedHero, actualHero);
    }
}