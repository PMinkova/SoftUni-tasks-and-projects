namespace FootballTeam.Tests
{
    using System;

    using NUnit.Framework;

    public class Tests
    {
        private FootballPlayer player;

        [SetUp]
        public void Setup()
        {
            player = new FootballPlayer("Mesi", 10, "Forward");
        }

        [Test]
        public void ConstructorShouldInitializeCollectionProperly()
        {
            var team = new FootballTeam("National team", 16);

            Assert.IsNotNull(team.Players);
        }

        [Test]
        public void CtorShouldInitializePropertiesCorrectly()
        {
            var team = new FootballTeam("National team", 16);

            Assert.AreEqual("National team", team.Name);
            Assert.AreEqual(16, team.Capacity);
        }

        [TestCase(null)]
        [TestCase("")]
        public void ConstructorShouldThrowAnExceptionWhenNameIsNullOrEmpty(string name)
        {
            Assert.Throws<ArgumentException>(() => new FootballTeam(name, 16));
        }

        [Test]
        public void ConstructorShouldThrowAnExceptionForCapacityUnder15()
        {
            Assert.Throws<ArgumentException>(() => new FootballTeam("National team", 14));
        }

        [Test]
        public void AddShouldIncreaseCount()
        {
            var team = new FootballTeam("National team", 16);
            var result = team.AddNewPlayer(player);

            Assert.AreEqual(1, team.Players.Count);
        }

        [Test]
        public void AddShouldReturnTheCorrectMessage()
        {
            var team = new FootballTeam("National team", 16);
            team.AddNewPlayer(player);

            var expectedMessage =
                $"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}";
            var actualMessage = team.AddNewPlayer(player);

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void AddShouldReturnTheCorrectMessageWhenCapacityIsReached()
        {
            var team = new FootballTeam("National team", 16);

            for (int i = 1; i <= 16; i++)
            {
                team.AddNewPlayer(new FootballPlayer("1", i, "Forward"));
            }

            var expected = "No more positions available!";
            var actual = team.AddNewPlayer(player);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PickPlayerShouldReturnTheSearchedPlayer()
        {
            var team = new FootballTeam("National team", 16);
            team.AddNewPlayer(player);

            var expected = player;
            var actual = team.PickPlayer("Mesi");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlayerScoreShouldReturnTheCorrectMessage()
        {
            var team = new FootballTeam("National team", 16);
            team.AddNewPlayer(player);

            var expectedMessage = $"{player.Name} scored and now has 1 for this season!";
            var actual = team.PlayerScore(10);

            Assert.AreEqual(expectedMessage, actual);
        }

        [Test]
        public void PlayerScoreShouldIncreasePlayersGoalCount()
        {
            var team = new FootballTeam("National team", 16);
            team.AddNewPlayer(player);

            var result = team.PlayerScore(10);

            Assert.AreEqual(1, player.ScoredGoals);
            Assert.AreEqual(1, team.Players.Count);
        }
    }
}
