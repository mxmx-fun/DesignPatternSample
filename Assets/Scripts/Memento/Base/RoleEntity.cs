namespace DesignPatternSample.Memento
{
    public class RoleEntity
    {
        public int coin;
        public int level;
        public int diamond;

        public RoleEntity(int coin, int level, int diamond)
        {
            this.coin = coin;
            this.level = level;
            this.diamond = diamond;
        }

        public void Update() {
            level++;
        }
    }
}