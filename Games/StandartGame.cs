using System;
namespace lab2oop
{
    public class StandartGame : AbstractGame
    {
        public StandartGame() : base() { }
        public StandartGame(Account FirstOpponent, Account SecondOpponent, int Rating) : base(FirstOpponent, SecondOpponent, Rating)
        {

        }
        public override string GetString(int i)
        {
            return $"ID: {ID} {FirstOpponent.UserName,3}({FirstOpponent.Games[this]}) проти {SecondOpponent.UserName,3}({SecondOpponent.Games[this]}); Рейтинг: {Rating,3};  Переможець - {Winner.UserName,3} +{ WinPoints()}; Програвший: -{ LosePoints()};";
        }
        public override TypeOfGame GetType()
        {
            return TypeOfGame.Standart;
        }
    }
}

