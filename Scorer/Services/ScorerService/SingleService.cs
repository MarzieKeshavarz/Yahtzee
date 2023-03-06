using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scorer.Services.ScorerService
{
    public class SingleService : IScorerService
    {
        public SingleService(int number)
        {
            Number = number;
        }
        private int Number { get; set; }

        public int Score(IEnumerable<int> dices)
        {
            return dices.Count(x => x == Number) * Number;
        }
    }
}
