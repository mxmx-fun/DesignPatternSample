namespace DesignPatternSample.FlyWeight {

    public class RoleEntity {

        public AttrParam baseAttr;
        public int level;
        public int maxHp;
        public int currentHp;
        public int currentAtk;
        public int currentDef;
        public int currentSpd;

        public void SetBaseAttr(AttrParam baseAttr) {
            this.baseAttr = baseAttr;
        }

        public void InitAttr() {
            maxHp = baseAttr.baseHpMax + baseAttr.growHpMax * (level - 1);
            currentHp = maxHp;
            currentAtk = baseAttr.baseAtk + baseAttr.growAtk * (level - 1);
            currentDef = baseAttr.baseDef + baseAttr.growDef * (level - 1);
            currentSpd = baseAttr.baseSpd + baseAttr.growSpd * (level - 1);
        }
    }
}