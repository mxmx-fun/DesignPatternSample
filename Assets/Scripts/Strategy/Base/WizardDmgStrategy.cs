using DesignPatternSample.Bridge;

namespace DesignPatternSample.Strategy {

    public class WizardDmgStrategy : IDamageStrategy
    {
        public int GetDamage(RoleEntity role)
        {
            return role.ATK * 5;
        }
    }
}