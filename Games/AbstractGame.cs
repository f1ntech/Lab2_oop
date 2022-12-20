using System;
namespace lab2oop
{
    public enum TypeOfGame {
        Solo,
        Standart,
        Training
    }
    public abstract class AbstractGame
    {
        public int count = 0;
        public static int countId = 0;
        public Account FirstOpponent;
        public Account SecondOpponent;
        public Account Winner;
        public int Rating { get; set; }
        public int ID { get; set; }

        public AbstractGame() {
            countId++;
            ID = countId;
            FirstOpponent = null;
            SecondOpponent = null;
            Winner = null;
            Rating = default(int);
        }
        public AbstractGame(Account FirstOpponent, Account SecondOpponent, int Rating)
        {
            this.FirstOpponent = FirstOpponent;
            this.SecondOpponent = SecondOpponent;
            if (Rating >= 0)
            {
                this.Rating = Rating;
            }
            else throw new Exception("Від'ємний рейтинг");
            countId++;
            ID = countId;
        }
        public Account GetLoser() {
            if (FirstOpponent == Winner)
            {
                return SecondOpponent;
            }
            else return FirstOpponent;
        }
        public virtual int LosePoints() {
            if (FirstOpponent==Winner) {
                return Convert.ToInt32(Rating / SecondOpponent.GetKoef);
            }
            else return Convert.ToInt32(Rating / FirstOpponent.GetKoef);
        }
        public virtual int WinPoints() {
            return Convert.ToInt32(Rating * Winner.GetKoef);
        }
        public abstract string GetString(int i);
        public abstract TypeOfGame GetType();
    }
}

