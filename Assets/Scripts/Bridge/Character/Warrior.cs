namespace DesignPatternSample.Bridge
{
    public class Warrior : ICharacter
    {
        public void InitAttr(RoleEntity role)
        {
            role.HP = 10 * role.Level;
            role.ATK = 2 * role.Level;
            role.SPD = 1 * role.Level;
        }
    }

}