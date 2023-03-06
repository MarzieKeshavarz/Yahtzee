using Scorer.Services.ScorerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scorer.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {

        public List<string> UsedServices = new List<string>();

        public IScorerService CreateService(string orderString)
        {
            orderString = orderString.Substring(orderString.IndexOf(')') + 1).Trim().ToLower();

            switch (orderString)
            {
                case "fullhouse":
                    {
                        return new FullHouseService();
                    }
                case "ones":
                    {
                        var service = new SingleService(1);
                        return service;
                    }
                case "twoes":
                    {
                        var service = new SingleService(2);
                        return service;
                    }
                case "threes":
                    {
                        var service = new SingleService(3);
                        return service;
                    }
                case "fours":
                    {
                        var service = new SingleService(4);
                        return service;
                    }
                case "fives":
                    {
                        var service = new SingleService(5);
                        return service;
                    }
                case "sixes":
                    {
                        var service = new SingleService(6);
                        return service;
                    }
                default:
                    {
                        return null;
                    }
            }
        }

        public int[] GetDices(string orderString)
        {
            var dices = orderString.Substring(orderString.IndexOf('(') + 1, orderString.IndexOf(')') - 1);

            return dices.Split(',').Select(x => int.Parse(x)).ToArray();
        }

        public bool IsUsedCategory(string orderString)
        {
            orderString = orderString.Substring(orderString.IndexOf(')') + 1).Trim().ToLower();

            if (UsedServices.Any(x => x == orderString))
                return true;

            UsedServices.Add(orderString);

            return false;
        }
    }
}
