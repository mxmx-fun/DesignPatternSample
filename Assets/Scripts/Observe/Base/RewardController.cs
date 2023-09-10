using UnityEngine;

namespace DesignPatternSample.Observe
{
    public class RewardController
    {
        BattleController battleController;

        public void Inject(BattleController battleController) {
            this.battleController = battleController;
            this.battleController.OnBattleFinish += OnBattleFinish;
        }

        public void OnBattleFinish(BattleResult result) {
            if (result == BattleResult.Win) {
                Debug.Log("获得奖励");
            }
        }


    }
}