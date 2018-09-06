using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunGame
{
    class GameVirus
    {
        public List<Игрок> gamers { get; private set; }
        private List<Игрок> virused;

        public  GameVirus()
        {
            gamers = new List<Игрок>();
            virused = new List<Игрок>();
        }

        public void AddGamer( Игрок gamer)
        {
            //пришел новый игрок, добавляем его в список играков и устанавливаем ему вирус
            gamers.Add(gamer);
            SetNewVirus(gamer);
        }

        private void SetNewVirus(Игрок gamer)
        {

        }

        public void Step()
        {
            RunAll();
            FindNewVirus();
        }

        private void RunAll()
        {
            foreach (Игрок item in gamers)
            {
                item.Беги();
            }
        }

        private void FindNewVirus()
        {

        }
    }
}
