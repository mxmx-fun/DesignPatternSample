namespace DesignPatternSample.Adapter
{

    public class EnemyEntity
    {

        public virtual void Attri()
        {
            UnityEngine.Debug.Log("属性贼牛");
        }

        public virtual void Action()
        {
            UnityEngine.Debug.Log("只会普通攻击");
        }
    }
}