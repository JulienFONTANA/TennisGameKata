using System;
using System.Collections.Generic;

namespace TennisGameKata
{
    public class Game : IGame
    {
        private IScoreHelper scoreHelper { get; set; }
        private Random rand { get; set; }
        public List<int> Scores;

        public Game()
        {
            rand = new Random(DateTime.Now.Second);

            scoreHelper = new ScoreHelper();
            Scores = new List<int>() { 0, 0 };
        }

        public void play()
        {
            while (!GameIsOver())
            {
                PlayABall();
                DisplayScores();
            }
        }

        public void PlayABall()
        {
            var winner = rand.Next(0, 2);

            if (winner == 0)
            {
                Score(0);
            }
            else
            {
                Score(1);
            }
        }

        public void DisplayScores()
        {
            scoreHelper.DisplayScore(Scores);
        }

        public void Score(int TeamToScore)
        {
            scoreHelper.Score(Scores, TeamToScore);
        }

        public bool GameIsOver()
        {
            return scoreHelper.GameIsOver(Scores);
        }
    }
}