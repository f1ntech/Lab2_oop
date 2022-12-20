using System;
namespace lab2oop
{
    public class GameFactory
    {
        public static AbstractGame GetGame(TypeOfGame game, Account FirstOpponent, Account SecondOpponent, int Rating) {
            switch (game) {
                case TypeOfGame.Solo : { return new SoloGame(FirstOpponent, null, Rating); }
                case TypeOfGame.Standart: { return new StandartGame(FirstOpponent, SecondOpponent, Rating); }
                case TypeOfGame.Training: { return new TrainingGame(FirstOpponent, SecondOpponent, 0); }
            }
            return null;
        }
    }
}

