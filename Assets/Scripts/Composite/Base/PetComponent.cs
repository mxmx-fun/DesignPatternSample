namespace DesignPatternSample.Composite {

    public class PetComponent:ICombatEffectiveness {
            
            public int GetCombatEffectiveness() {
                //假设这边是宠物的战斗力计算
                //可能会有宠物品阶、宠物等级、宠物技能等一些列操作计算出宠物的战斗力
                return 50;
            }
    }
}