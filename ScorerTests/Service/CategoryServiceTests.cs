using NUnit.Framework;
using Scorer.Services.CategoryService;
using Scorer.Services.ScorerService;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScorerTests.Service
{
    public class CategoryServiceTests
    {
        [Test]
        public void CreateServiceShouldReturnFullHouseService()
        {
            var service = new CategoryService();

            var result = service.CreateService("fullhouse");

            Assert.True(result is FullHouseService);
        }

        [Test]
        public void CreateServiceShouldReturnNull()
        {
            var service = new CategoryService();

            var result = service.CreateService("ones");

            Assert.IsNull(result);
        }

        [Test]
        public void GetDicesShouldReturnArrayOfDices()
        {
            var service = new CategoryService();

            var result = service.GetDices("fullhouse");

            Assert.AreEqual(new int[] { 1, 2, 1, 4, 5 }, result);
        }


        [Test]
        public void IsUsedCategoryShouldReturnTrue()
        {
            var service = new CategoryService();

            service.IsUsedCategory("(1,2,1,4,5) fullhouse");
            var result = service.IsUsedCategory("(1,2,1,4,5) fullhouse");

            Assert.True(result);
        }

        [Test]
        public void IsUsedCategoryShouldReturnFalse()
        {
            var service = new CategoryService();

            service.IsUsedCategory("(1,2,1,4,5) ones");
            var result = service.IsUsedCategory("(1,2,1,4,5) fullhouse");

            Assert.False(result);
        }
    }
}
