namespace RunGame
{
    interface Игрок
    {
        void Беги();
        void Голя();
        void НеГоля();
        bool Поймал(Игрок obj);
    }
}
