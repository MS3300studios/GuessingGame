using System;

namespace GameModel
{
    public class Game
    {
        private readonly int randomized; //można przypisać (=) mu coś tylko tu albo w konstruktorze
        public GameStatus Status { get; private set; }
        
        public Game(int a = 1, int b = 100)
        {
            Random rnd = new Random();
            randomized = rnd.Next(a, b+1);
        }
        public int Randomized
        {
            get
            {
                if (Status == GameStatus.Finished)
                    return randomized;
                else
                    throw new NotSupportedException("during the game, you cannot get this information");
            }
        }

        public Anwsers Anwser(int proposal)
        {
            if (randomized < proposal)
                return Anwsers.TooLittle;
            else if (randomized > proposal)
                return Anwsers.TooMuch;
            else
            {
                Status = GameStatus.Finished;
                return Anwsers.Score;
            }
        }
    }

    public enum GameStatus
    {
        Started,
        Progressing,
        Paused,
        Finished
    }
    public enum Anwsers
    {
        TooLittle = -1,
        Score = 0,
        TooMuch = 1
    }

}
