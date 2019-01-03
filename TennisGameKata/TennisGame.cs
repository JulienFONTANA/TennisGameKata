namespace TennisGameKata
{
    public class TennisGame
    {
        private IGame tennisGame { get; set; }

        public TennisGame()
        {
            tennisGame = new Game();
        }

        public void PlayTennis()
        {
            tennisGame.play();
        }
    }
}
