namespace DesignPatternSample.Composite {

    public class WeaponComponent:ICombatEffectiveness {

        public int GetCombatEffectiveness() {
            //假设这边是武器的战斗力计算
            //可能会有武器品阶、武器等级、武器强化等一些列操作计算出武器的战斗力
            return 100;
        }
    }
}