using DesignPatternSample.Bridge;
using DesignPatternSample.Strategy;

namespace DesignPatternSample.Factory
{
    public enum RoleType
    {
        Warrior,
        Wizard,
    }

    public enum WeaponType
    {
        Stick,
        Gun,
    }
    public class Factory
    {
        public RoleEntity CreateRole(RoleType roleType, WeaponType weaponType, int level)
        {
            ICharacter character;
            IWeapon weapon;
            IDamageStrategy damageStrategy;
            switch (roleType)
            {
                case RoleType.Warrior:
                    character = new Warrior();
                    damageStrategy = new WarriorDmgStrategy();
                    break;
                case RoleType.Wizard:
                    character = new Wizard();
                    damageStrategy = new WizardDmgStrategy();
                    break;
                default:
                    character = new Warrior();
                    damageStrategy = new WarriorDmgStrategy();
                    break;
            }

            switch (weaponType)
            {
                case WeaponType.Stick:
                    weapon = new Stick();
                    break;
                case WeaponType.Gun:
                    weapon = new Gun();
                    break;
                default:
                    weapon = new Stick();
                    break;
            }

            return new RoleEntity(character, weapon, damageStrategy, level);
        }
    }
}