using NUnit.Framework;
using Scorer.Services.ScorerService;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScorerTests.Service
{
    public class SingleServiceTests
    {

        [Test]
        public void ScoreShouldRerunSumOfOnes()
        {
            var service = new SingleService(1);

            var result = service.Score(new int[] { 1, 1, 2, 5, 6 });

            Assert.AreEqual(2, result);
        }

        [Test]
        public void ScoreShouldRerunZero()
        {
            var service = new SingleService(1);

            var result = service.Score(new int[] { 4, 4, 2, 5, 6 });

            Assert.AreEqual(0, result);
        }

        [Test]
        public void ScoreShouldRerunSumOfTwoes()
        {
            var service = new SingleService(2);

            var result = service.Score(new int[] { 1, 2, 2, 5, 6 });

            Assert.AreEqual(4, result);
        }
        
        [Test]
        public void ScoreShouldRerunSumOfSixes()
        {
            var service = new SingleService(6);

            var result = service.Score(new int[] { 1, 6, 6, 5, 6 });

            Assert.AreEqual(18, result);
        }


    }
}
