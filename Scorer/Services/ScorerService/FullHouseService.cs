using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scorer.Services.ScorerService
{
    public class FullHouseService : IScorerService
    {
        public int Score(IEnumerable<int> dices)
        {
            var groupedBy = dices.GroupBy(x => x);

            if (groupedBy.Any(x => x.Count() == 2) && groupedBy.Any(x => x.Count() == 3))
                return dices.Sum();

            return 0;
        }
    }
}
