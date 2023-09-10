using UnityEngine;

namespace DesignPatternSample.Observe
{
    public class ObserveSample : MonoBehaviour
    {
        void Start()
        {
            BattleController battleController = new BattleController();
            AchievementController achievementController = new AchievementController();
            RewardController rewardController = new RewardController();

            achievementController.Inject(battleController);
            rewardController.Inject(battleController);

            battleController.BattleFinish();
        }
    }
}