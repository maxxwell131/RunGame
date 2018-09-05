using System;
using System.Windows.Forms;

namespace RunGame
{
    public partial class FormGame : Form
    {
        Arena arena;
        GameCatch game;

        public FormGame()
        {
            InitializeComponent();
            arena = new Arena(picture);
            game = new GameCatch();
            timer.Enabled = true;
        }

        private void buttonAddGamer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                game.AddGamer(Arena.NewCircle());
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            game.Step();
            arena.Clear();

            foreach (Circle circle in game.gamers)
            {
                arena.Show(circle);
                arena.Refresh();
            }
        }
    }
}
