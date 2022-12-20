namespace lab2oop
{
    class Program
    {
        static void Main() {
            var Artem = new BasicAccount("Artem");
            var Sasha = new PremiumPlusAccount("Sasha");
            var Anton = new BasicAccount("Anton");

              var game1 = GameFactory.GetGame(TypeOfGame.Standart, Sasha, Artem, 20);
              var game2 = GameFactory.GetGame(TypeOfGame.Standart, Sasha, Artem, 20);
              var game3 = GameFactory.GetGame(TypeOfGame.Solo, Anton, null, 10);
              var game4 = GameFactory.GetGame(TypeOfGame.Training, Artem, Sasha, 20);
              var game5 = GameFactory.GetGame(TypeOfGame.Training, Anton, Artem, 20);

            Sasha.WinGame(game1);
            Sasha.WinGame(game2);
            Anton.WinGame(game3);
            Artem.WinGame(game4);
            Anton.WinGame(game5);


            Artem.GetStats();
            Sasha.GetStats();
            Anton.GetStats();
        }    
    }
}