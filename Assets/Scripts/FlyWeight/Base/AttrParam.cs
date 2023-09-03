namespace DesignPatternSample.FlyWeight
{
    public struct AttrParam {
        //Base
        public int id;
        public string name;
        public int baseAtk;
        public int baseDef;
        public int baseHpMax;
        public int baseSpd;

        //Grow(per level)
        public int growAtk;
        public int growDef;
        public int growHpMax;
        public int growSpd;

        public AttrParam(int id, string name, int baseAtk, int baseDef, int baseHpMax, int baseSpd, int growAtk, int growDef, int growHpMax, int growSpd) {
            this.id = id;
            this.name = name;
            this.baseAtk = baseAtk;
            this.baseDef = baseDef;
            this.baseHpMax = baseHpMax;
            this.baseSpd = baseSpd;
            this.growAtk = growAtk;
            this.growDef = growDef;
            this.growHpMax = growHpMax;
            this.growSpd = growSpd;
        }
    }
}