using Microsoft.Extensions.DependencyInjection;
using Scorer.Services.CategoryService;
using Scorer.Services.ScorerService;
using System;

namespace Scorer
{
    public class GameScorer
    {
        private ICategoryService _categoryService { get; set; }
        public GameScorer()
        {

            var services = new ServiceCollection()
                 .AddTransient<ICategoryService, CategoryService>()
                 .BuildServiceProvider();

            _categoryService = services.GetService<ICategoryService>();

        }
        public int ProcessEachRound(string orderString)
        {

            try
            {
                int[] dices = _categoryService.GetDices(orderString);

                if (_categoryService.IsUsedCategory(orderString))
                    throw new ArgumentOutOfRangeException();

                IScorerService service = _categoryService.CreateService(orderString);

                return service.Score(dices);

            }
            catch (ArgumentOutOfRangeException x)
            {
                throw;
            }


        }

    }
}