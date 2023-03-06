
using Scorer.Services.ScorerService;

namespace Scorer.Services.CategoryService
{
    public interface ICategoryService
    {
        int[] GetDices(string orderString);

        IScorerService CreateService(string orderString);

        bool IsUsedCategory(string orderString);
    }
}
