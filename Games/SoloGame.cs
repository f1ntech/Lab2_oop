using System;
namespace lab2oop
{
    public class SoloGame : AbstractGame
    {
        public SoloGame() : base() {}
        public SoloGame(Account FirstOpponent, Account SecondOpponent, int Rating) : base(FirstOpponent, null, Rating) {
   
        }
        public override int LosePoints()
        {
            if (FirstOpponent != Winner)
            {
                return Convert.ToInt32(Rating / FirstOpponent.GetKoef);
            }
            return 0;
        }
        public override int WinPoints()
        {
            if (FirstOpponent == Winner)
            {
                return Convert.ToInt32(Rating * Winner.GetKoef);
            }
            return 0;
        }
        public override string GetString(int i)
        {
            if (FirstOpponent == Winner) {
                return $"ID: {ID} {FirstOpponent.UserName,3}({FirstOpponent.Games[this]}) проти Бота;  Рейтинг: {Rating,3};  Переможець - {Winner.UserName,3} +{ WinPoints()};";
            }
            return $"Соло гра ID: {ID}; {FirstOpponent.UserName,3}({FirstOpponent.Games[this]}) проти Бота;  Рейтинг: {Rating,3};  Переможець - Бот; Програвший: -{ LosePoints()};";
        }
        public override TypeOfGame GetType() {
            return TypeOfGame.Solo;
        }
    }
}

