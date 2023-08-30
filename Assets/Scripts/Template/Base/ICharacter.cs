namespace DesignPatternSample.Template {
    public abstract class ICharacter {
        public abstract int GetDamage();

        public void Attack() {
            // 伤害计算
            int damage = GetDamage();
            // 播放动画
            UnityEngine.Debug.Log("播放攻击动画");
            // 播放特效
            UnityEngine.Debug.Log("播放攻击特效");
            // 伤害输出
            UnityEngine.Debug.Log("伤害输出：" + damage);
        }
    }
} 