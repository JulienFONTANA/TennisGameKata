using NFluent;
using NUnit.Framework;
using System.Collections.Generic;
using TennisGameKata;

namespace TennisGameKataTests
{
    [TestFixture]
    public class ScoreHelperTests
    {
        public IScoreHelper scoreHelper { get; set; }
        public int teamToScore = 0;
        public int otherTeam = 1;

        [SetUp]
        public void SetUp()
        {
            scoreHelper = new ScoreHelper();
        }

        [Test]
        public void Should_Increade_Score_When_Point_Is_Scored()
        {
            var Scores = new List<int> { 0, 0 };
            scoreHelper.Score(Scores, teamToScore);
            Check.That(Scores[teamToScore]).IsEqualTo(15);
        }

        [Test]
        public void Should_Win_When_Scoring_At_40_While_Other_Team_Has_Less()
        {
            var Scores = new List<int> { 40, 0 };
            scoreHelper.Score(Scores, teamToScore);
            Check.That(Scores[teamToScore]).IsEqualTo(60);
        }

        [Test]
        public void Should_Win_When_Scoring_Twice_At_40_While_Other_Team_Has_40()
        {
            var Scores = new List<int> { 40, 40 };
            scoreHelper.Score(Scores, teamToScore);
            scoreHelper.Score(Scores, teamToScore);
            Check.That(Scores[teamToScore]).IsEqualTo(60);
        }

        [Test]
        public void Should_Take_Advantage_When_Scoring_At_40_While_Other_Team_Has_40()
        {
            var Scores = new List<int> { 40, 40 };
            scoreHelper.Score(Scores, teamToScore);
            Check.That(Scores[teamToScore]).IsEqualTo(50);
        }

        [Test]
        public void Should_Deuce_When_Scoring_At_40_While_Other_Team_Has_50()
        {
            var Scores = new List<int> { 40, 50 };
            scoreHelper.Score(Scores, teamToScore);
            Check.That(Scores[otherTeam]).IsEqualTo(40);
        }

        [Test]
        public void Should_Return_True_When_Game_Is_Over()
        {
            var Scores = new List<int> { 60, 0 };
            var isOver = scoreHelper.GameIsOver(Scores);
            Check.That(isOver).IsEqualTo(true);
        }
    }
}
