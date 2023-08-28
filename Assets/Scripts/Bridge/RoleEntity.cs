namespace DesignPatternSample.Bridge
{
    public class RoleEntity
    {
        ICharacter characterType;
        IWeapon weaponType;

        public RoleEntity(ICharacter character, IWeapon weapon, int level) {
            characterType = character;
            weaponType = weapon;
            this.level = level;
            character.InitAttr(this); 
        }

        public void Attack() {
            weaponType.Attack();
        }

        int level;
        public int Level { get => level; set => level = value; }

        int hp;
        public int HP { get => hp; set => hp = value; }

        int atk;
        public int ATK { get => atk; set => atk = value; }

        int spd;
        public int SPD { get => spd; set => spd = value; }
    }
}