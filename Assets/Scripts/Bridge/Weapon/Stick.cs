namespace DesignPatternSample.Bridge
{
    public class Stick : IWeapon
    {
        public void Attack()
        {
            // 棍子的攻击方式
            UnityEngine.Debug.Log("执行棍子的攻击方式");
        }

        public void ShowEffect()
        {
            // 显示棍子的攻击效果
            UnityEngine.Debug.Log("播放棍子的攻击动画");
        }
    }

}