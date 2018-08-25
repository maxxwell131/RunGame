using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunGame
{
    class GameCatch
    {
       public List<Игрок> gamers { get; private set; }
        Игрок leader;

        public GameCatch()
        {
            gamers = new List<Игрок>();
        }

        public void AddGamer(Игрок gamer)
        {
            gamers.Add(gamer); // добавили игрока в игру
            SetNewLeader(gamer); //тк он последний зашел в игру, он ловит
        }

        private void SetNewLeader(Игрок gamer)
        {
            throw new NotImplementedException();
        }

        public void Step()
        {
            RunAll();
            FindNewLeader();
        }

        private void FindNewLeader()
        {
            throw new NotImplementedException();
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
