using System.Collections.Generic;

namespace TennisGameKata
{
    public interface IScoreHelper
    {
        void Score(List<int> Scores, int teamToScore);
        void DisplayScore(List<int> Scores);
        bool GameIsOver(List<int> Scores);
    }
}