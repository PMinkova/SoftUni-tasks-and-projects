// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 
namespace FestivalManager.Tests
{
    using System;
    using System.Collections.Generic;

    using Entities;
    using NUnit.Framework;

    [TestFixture]
    public class StageTests
    {
        private Stage stage;
        private TimeSpan timeSpan;

        [SetUp]
        public void StartUp()
        {
            stage = new Stage();
            timeSpan = new TimeSpan(0, 2, 10);
        }

        [Test]
        public void ConstructorShouldInitializeSongCollection()
        {
            var songs = new List<Song>();
            Assert.IsNotNull(songs);
        }

        [Test]
        public void ConstructorShouldInitializePerformerCollection()
        {
            var performers = new List<Performer>();
            Assert.IsNotNull(performers);
        }

        [Test]
        public void AddPerformerShouldIncreasePerformersCollectionCount()
        {
            var performer = new Performer("Lili", "Ivanova", 60);
            this.stage.AddPerformer(performer);

            Assert.AreEqual(1, this.stage.Performers.Count);
        }

        [Test]
        public void AddPerformerShouldThrowAnExceptionWhenPerformerIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => this.stage.AddPerformer(null));
        }

        [Test]
        public void AddPerformerShouldThrowAnExceptionWhenPerformerIsUnder18()
        {
            var performer = new Performer("Lili", "Ivanova", 16);
            Assert.Throws<ArgumentException>(() => this.stage.AddPerformer(performer));
        }

        [Test]
        public void AddSongShouldThrowAnExceptionWhenSongIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => this.stage.AddSong(null));
        }

        [Test]
        public void AddSongShouldThrowAnExceptionWhenSongDurationIsUnderOneMinute()
        {
            var song = new Song("I love you", new TimeSpan(0, 0, 45));
            Assert.Throws<ArgumentException>(() => this.stage.AddSong(song));
        }

        [Test]
        public void AddSongToPerformerShouldThrowAnExceptionWhenSongIsNull()
        {
            var song = new Song("I love you", timeSpan);
            this.stage.AddSong(song);

            Assert.Throws<ArgumentNullException>(() => this.stage.AddSongToPerformer("I love you", null));
        }

        [Test]
        public void AddSongToPlayerShouldThrowAnExceptionWhenPerformerIsNull()
        {
            var performer = new Performer("Lili", "Ivanova", 60);
            this.stage.AddPerformer(performer);

            Assert.Throws<ArgumentNullException>(() => this.stage.AddSongToPerformer(null, performer.FullName));
        }

        [Test]
        public void AddSongToPlayerShouldReturnTheCorrectMessage()
        {
            var song = new Song("Vetrove", timeSpan);
            var performer = new Performer("Lili", "Ivanova", 60);

            this.stage.AddSong(song);
            this.stage.AddPerformer(performer);

            performer.SongList.Add(song);

            var expectedMessage = $"{song} will be performed by {performer}";
            var actualMessage = this.stage.AddSongToPerformer(song.Name, performer.FullName);

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void PlayShouldReturnMessageWithAllPerformersAndSongsCount()
        {
            var performer = new Performer("Lili", "Ivanova", 60);
            var firstSong = new Song("Vetrove", timeSpan);
            var secondSong = new Song("Za tebe byah", timeSpan);

            this.stage.AddPerformer(performer);
            this.stage.AddSong(firstSong);
            this.stage.AddSong(secondSong);

            performer.SongList.Add(firstSong);
            performer.SongList.Add(secondSong);

            var expectedMessage = $"{stage.Performers.Count} performers played 2 songs";
            var actualMessage = this.stage.Play();

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}