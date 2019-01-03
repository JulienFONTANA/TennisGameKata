using System;
using System.Collections.Generic;

namespace TennisGameKata
{
    public class Game : IGame
    {
        private IScoreHelper scoreHelper { get; set; }

        public List<int> Scores;

        public Game()
        {
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
            // TODO - Display Winner of the Set
        }

        public void PlayABall()
        {
            Random rand = new Random(DateTime.Now.Second);

            var winner = rand.Next(0, 1);

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
            //Console.WriteLine($"Score is {_scoreBoard[Scores[0]]} to {_scoreBoard[Scores[1]]}");
        }

        public void Score(int TeamToScore)
        {
            // TODO - Increase score, don't forget deuce
            scoreHelper.Score(Scores, TeamToScore);
        }

        public bool GameIsOver()
        {
            // TODO - Check when game is actually over
            return false;
        }
    }
}