using System;
namespace lab2oop
{ 
    public abstract class Account
    {
        public string UserName { get; set; }
        public int CurrentRating { get; set; }
        public int WinsInRow { get; set; }
        public Dictionary<AbstractGame,int> Games = new();

        public Account(string UserName)
        {
            this.UserName = UserName;
            CurrentRating = 100;
        }
        public virtual void GetStats()
        {
            Console.WriteLine($"Статистика гравця {UserName}");
            for (int i = 0; i < Games.Count; i++)
            {
                Console.WriteLine(Games.ElementAt(i).Key.GetString(i));
            }
            Console.WriteLine();
        }
        public virtual double GetKoef
        {
            get { return 1; }
        }
        public virtual void Print()
        {
            Console.WriteLine($"Ім'я: {UserName} -> Рейтинг: {CurrentRating}");
        }
        public void DecreaseRating(AbstractGame game)
        {
            if (CurrentRating - game.LosePoints() > 0)
            {
                CurrentRating -= game.LosePoints();
            }
            else CurrentRating = 1;
            if (Games.ContainsKey(game))
            {
                Games[game] = CurrentRating;
            }
            else
            {
                Games.Add(game, CurrentRating);
            }
        }
        public void IncreaseRating(AbstractGame game)
        {
            CurrentRating += game.WinPoints();
            if (Games.ContainsKey(game))
            {
                Games[game] = CurrentRating;
            }
            else
            {
                Games.Add(game, CurrentRating);
            }
        }
        public void LoseGame(AbstractGame game)
        {
            foreach (var item in Games.Keys)
            {
                if (item != null && item == game)
                {
                    game.count++;
                    if (game.count > 2)
                    {
                        return;
                    }
                }
            }
            if (WinsInRow > 0) WinsInRow--;
            if (game.GetType() == TypeOfGame.Solo) {
                if (game.FirstOpponent != this) return;
                game.Winner = null;
                DecreaseRating(game);
            }
            else
            {
                if(game.FirstOpponent == this)
                {
                    game.Winner = game.SecondOpponent;
                }
                else
                {
                    game.Winner = game.FirstOpponent;
                }
                game.Winner.IncreaseRating(game);
                game.GetLoser().DecreaseRating(game);
            }
        }
        public void WinGame(AbstractGame game)
        {
            foreach(var item in Games.Keys)
            {
                if (item != null && item == game)
                {
                    game.count++;
                    if (game.count > 1)
                    {
                        return;
                    }
                }
            }
            game.Winner = this;
            WinsInRow++;
            if(WinsInRow > 2)
            {
                game.Winner.IncreaseRating(game);
            }
            if (game.GetType() == TypeOfGame.Solo)
            {
                if (game.FirstOpponent != this) return;
                IncreaseRating(game);
            }
            else
            {
                game.GetLoser().DecreaseRating(game);
                game.Winner.IncreaseRating(game);
            }
        }
    }
}
