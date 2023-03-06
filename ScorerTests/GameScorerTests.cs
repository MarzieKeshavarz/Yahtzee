using NUnit.Framework;
using Scorer;
using System;

namespace ScorerTests
{
    [TestFixture]
    public class ScorerTests
    {
        [Test]
        public void ProcessEachRoundShouldReturnScore()
        {
            var sut = new GameScorer();

            sut.ProcessEachRound("(1,1,2,2,2) ones");
           
            var result = sut.ProcessEachRound("(1,1,2,2,2) fullhouse");

            Assert.AreEqual(8, result);
        }

        [Test]
        public void ProcessEachRoundShouldReturnArgumentExceptoin()
        {
            var sut = new GameScorer();

            sut.ProcessEachRound("(1,1,2,2,2) fullhouse");

            Assert.That(() => sut.ProcessEachRound("(1,1,2,2,2) fullhouse"), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void GameShouldReturnFinalScore()
        {
            var sut = new GameScorer();

            int finalScore = 0;

            finalScore += sut.ProcessEachRound("(1,1,2,2,2) ones");
            finalScore += sut.ProcessEachRound("(1,1,2,2,2) twoes");
            finalScore += sut.ProcessEachRound("(1,3,3,3,2) threes");
            finalScore += sut.ProcessEachRound("(1,1,2,2,2) fullhouse");

            Assert.AreEqual(25, finalScore);
        }
    }
}