namespace DesignPatternSample.CompositeEntity {
    public class Weapon {

        public string Name { get; set; }
        public int Attack { get; set; }

        public Weapon(string name,int Attack) {
            this.Name = name;
            this.Attack = Attack;
        }
    }
}