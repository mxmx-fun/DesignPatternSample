namespace DesignPatternSample.Adapter
{

    public class PetEntity : RoleEntity
    {
        EnemyEntity enemy;

        public PetEntity() {
            enemy = new EnemyEntity();
        }

        public override void Attri()
        {
            enemy.Attri();
        }
    }
}