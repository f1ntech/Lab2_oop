using System;
namespace lab2oop
{
    public class TrainingGame : AbstractGame
    {
        public TrainingGame() : base() { }
        public TrainingGame(Account FirstOpponent, Account SecondOpponent, int Rating) : base(FirstOpponent, SecondOpponent, 0)
        {

        }
        public override string GetString(int i)
        {
            return $"Тренувальна гра ID: {ID}; {FirstOpponent.UserName,3}({FirstOpponent.Games[this]}) проти {SecondOpponent.UserName,3}({SecondOpponent.Games[this]});  Переможець - {Winner.UserName,3};";
        }
        public override TypeOfGame GetType()
        {
            return TypeOfGame.Training;
        }
    }
}

