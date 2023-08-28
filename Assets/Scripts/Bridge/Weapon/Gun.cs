namespace DesignPatternSample.Bridge
{
    public class Gun : IWeapon
    {
        public void Attack()
        {
            // 枪的攻击方式
            UnityEngine.Debug.Log("执行枪的攻击方式");
        }

        public void ShowEffect()
        {
            // 显示枪的攻击效果
            UnityEngine.Debug.Log("播放枪的攻击动画");
        }
    }

}