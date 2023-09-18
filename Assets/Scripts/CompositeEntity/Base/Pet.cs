namespace DesignPatternSample.CompositeEntity {
    public class Pet {
        public string Name { get; set; }
        public int Attack { get; set; }

        public Pet(string name,int Attack) {
            this.Name = name;
            this.Attack = Attack;
        }
    }
}