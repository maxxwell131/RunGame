using System.Collections.Generic;

namespace RunGame
{
    class GameCatch
    {
       public List<Игрок> gamers { get; private set; }
        Игрок leader;

        public GameCatch()
        {
            gamers = new List<Игрок>();
            leader = null;
        }

        public void AddGamer(Игрок gamer)
        {
            gamers.Add(gamer); // добавили игрока в игру
            SetNewLeader(gamer); //тк он последний зашел в игру, он ловит
        }

        private void SetNewLeader(Игрок gamer)
        {
            if (leader != null)
            {
                leader.НеГоля();
            }

            leader = gamer;
            leader.Голя();
        }

        public void Step()
        {
            RunAll();
            FindNewLeader();
        }

        private void FindNewLeader()
        {
            if (leader == null)
            {
                return;
            }

            foreach (Игрок item in gamers)
            {
                if (leader.Поймал(item))
                {
                    SetNewLeader(item);
                    break;
                }
            }
        }

        private void RunAll()
        {
            foreach (Игрок item in gamers)
            {
                item.Беги();
            }
        }
    }
}
