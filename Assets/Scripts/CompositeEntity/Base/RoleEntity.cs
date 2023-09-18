namespace DesignPatternSample.CompositeEntity {
    public class RoleEntity {

        public Attr Attr { get; set; }
        public Weapon Weapon { get; set; }
        public Pet Pet { get; set; }

        public RoleEntity() {
            Attr = new Attr(10);
            Weapon = new Weapon("长枪",10);
            Pet = new Pet("小狗",10);
        }
        
        public int GetAtk() {
            var totalAtk = Attr.Attack + Weapon.Attack + Pet.Attack;
            return totalAtk;
        }
    }
}