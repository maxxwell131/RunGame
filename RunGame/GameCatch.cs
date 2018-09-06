using System.Collections.Generic;

namespace RunGame
{
    class GameCatch
    {
       public List<Игрок> gamers { get; private set; }
        Игрок leader;
        int leaderSkipSteps;
        static int MaxSkipStep = 10;

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
            leaderSkipSteps = MaxSkipStep;
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

            //чтоб новый голя не передал старому голе латку
            if (leaderSkipSteps > 0)
            {
                leaderSkipSteps--;
                return;
            }

            foreach (Игрок item in gamers)
            {
                if (!leader.Equals(item))
                {
                    if (leader.Поймал(item))
                    {
                        SetNewLeader(item);
                        break;
                    }
                }               
            }
        }

        private void RunAll()
        {
            foreach (Игрок item in gamers)
            {
                // если лидер -стой, остальные беги
                if (!leader.Equals(item) || leaderSkipSteps == 0)
                    item.Беги();
            }
        }
    }
}
