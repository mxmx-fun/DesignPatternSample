using DesignPatternSample.Bridge;

namespace DesignPatternSample.Strategy {

    public class WarriorDmgStrategy : IDamageStrategy
    {
        public int GetDamage(RoleEntity role)
        {
            return role.ATK * 2;
        }
    }
}