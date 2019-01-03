using System.Collections.Generic;

namespace TennisGameKata
{
    public interface IScoreHelper
    {
        void Score(List<int> Scores, int teamToScore);
    }
}