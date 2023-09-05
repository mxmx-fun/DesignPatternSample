namespace DesignPatternSample.Composite {

    public class AttrComponent:ICombatEffectiveness {

        public int GetCombatEffectiveness() {
            //假设这边是角色的战斗力计算
            //可能会有角色基础战斗力、角色装备、角色坐骑、角色宠物等一些列操作计算出角色的战斗力
            return 1000;
        }
    }
}