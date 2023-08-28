namespace DesignPatternSample.Bridge
{
    public class Wizard : ICharacter
    {
        public void InitAttr(RoleEntity role)
        {
            role.HP = 5 * role.Level;
            role.ATK = 5 * role.Level;
            role.SPD = 3 * role.Level;
        }
    }

}