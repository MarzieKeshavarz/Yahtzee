using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Scorer.Services.ScorerService;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScorerTests.Service
{
    public class FullHouseServiceTests
    {

        [Test]
        public void ScoreShouldReturnSumOfDices()
        {
            var service = new FullHouseService();
            var result = service.Score(new int[] { 1, 1, 2, 2, 2 });
            Assert.AreEqual(8, result);
        }  
        
        [Test]
        public void ScoreShouldReturnZero()
        {
            var service = new FullHouseService();
            var result = service.Score(new int[] { 1, 1, 5, 2, 2 });
            Assert.AreEqual(0, result);
        }     
        
        [Test]
        public void ScoreShouldReturnZero1()
        {
            var service = new FullHouseService();
            var result = service.Score(new int[] { 5, 5, 5, 5, 5 });
            Assert.AreEqual(0, result);
        }
    }
}
