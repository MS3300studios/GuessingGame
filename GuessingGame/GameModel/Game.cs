using System;
using System.Collections.Generic; //dostarcza kolekcji w stylu np List

namespace GameModel
{
    public class Game
    {
        //data
        private readonly int randomized; //można przypisać (=) mu coś tylko tu albo w konstruktorze
        public GameStatus Status { get; private set; }
        
        //methods
        public Game(int a = 1, int b = 100)
        {
            Random rnd = new Random();
            randomized = rnd.Next(a, b+1);
            Status = GameStatus.Progressing;
            GameHistory = new List<Move>();
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

            if (randomized > proposal)
            {
                GameHistory.Add(new Move(proposal, Anwsers.TooLittle));
                return Anwsers.TooLittle;
            }
            else if (randomized < proposal)
            {
                GameHistory.Add(new Move(proposal, Anwsers.TooMuch));
                return Anwsers.TooMuch;
            }
            else
            {
                Status = GameStatus.Finished;
                return Anwsers.Score;
            }
        } //publiczna metoda typu Anwsers (ten typ to enum)
    
        public void GiveUp()
        {
            Status = GameStatus.Finished;
        }

        public List<Move> GameHistory { get; }
    
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
