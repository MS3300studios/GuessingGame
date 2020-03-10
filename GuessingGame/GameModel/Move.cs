using System;

namespace GameModel
{
    public class Move
    {

        public readonly int Proposal;
        public readonly Anwsers Anwser;
        public readonly DateTime When;

        //constructor
        public Move(int prop, Anwsers anws)
        {
            Proposal = prop;
            Anwser = anws;
            When = DateTime.Now;
        }

        public override string ToString()
            => $"{Proposal} | {Anwser} | {When}";
        
    }
}