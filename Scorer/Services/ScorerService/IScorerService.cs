
using System.Collections;
using System.Collections.Generic;

namespace Scorer.Services.ScorerService
{
    public interface IScorerService
    {
        int Score(IEnumerable<int> dices);
    }
}
