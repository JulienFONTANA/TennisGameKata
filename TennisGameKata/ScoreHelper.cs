﻿using System.Collections.Generic;

namespace TennisGameKata
{
    public class ScoreHelper : IScoreHelper
    {
        private readonly Dictionary<int, string> _scoreBoard = new Dictionary<int, string>
        {
            { 0, "Love" },
            { 15, "15" },
            { 30, "30" },
            { 40, "40" },
            { 50, "Advantage" },
            { 60, "Winner" }
        };

        public void Score(List<int> Scores, int teamToScore)
        {
            var actualScore = Scores[teamToScore];
            var otherScore = Scores[teamToScore == 0 ? 1 : 0];

            switch (actualScore)
            {
                case 0:
                    Scores[teamToScore] = 15;
                    return;

                case 15:
                    Scores[teamToScore] = 30;
                    return;

                case 30:
                    Scores[teamToScore] = 40;
                    return;

                case 40:
                    switch (otherScore)
                    {
                        // Takes advantege
                        case 40:
                            Scores[teamToScore] = 50;
                            return;

                        // Back to deuce
                        case 50:
                            Scores[teamToScore == 0 ? 1 : 0] = 40;
                            return;

                        // Won !
                        default:
                            Scores[teamToScore] = 60;
                            break;
                    }
                    return;

                default:
                    break;
            }
        }

        // DisplayScore
    }
}