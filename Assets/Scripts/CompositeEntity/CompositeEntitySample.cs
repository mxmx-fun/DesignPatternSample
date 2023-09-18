using UnityEngine;

namespace DesignPatternSample.CompositeEntity {
    public class CompositeEntitySample:MonoBehaviour {

        public void Start() {
            RoleEntity role = new RoleEntity();
            int atk = role.GetAtk();
            Debug.Log("攻击力为：" + atk);
        }
    }
}