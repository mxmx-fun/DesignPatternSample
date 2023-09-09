namespace DesignPatternSample.Memento
{
    public class GameDate
    {
        public int coin;
        public int level;
        public int diamond;

        public GameDate(int coin, int level, int diamond)
        {
            this.coin = coin;
            this.level = level;
            this.diamond = diamond;
        }
    }
}