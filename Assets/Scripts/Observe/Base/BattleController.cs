using System;

namespace DesignPatternSample.Observe
{
    public class BattleController
    {
        public event Action<BattleResult> OnBattleFinish;

        public void BattleFinish()
        {
            OnBattleFinish?.Invoke(BattleResult.Win);
        }
    }
}