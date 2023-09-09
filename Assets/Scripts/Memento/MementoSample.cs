using UnityEngine;


namespace DesignPatternSample.Memento
{

    public class MementoSample : MonoBehaviour
    {
        RoleEntity role;
        DateManager dateManager;

        public void Awake() {
            role = new RoleEntity(100, 1, 0);
            dateManager = new DateManager();
        }

        public void Start() {
            role.Update();
            dateManager.SaveDate(role,0);
            Debug.Log("Role Level:" + role.level);
            role.Update();
            role.Update();
            role.Update();
            Debug.Log("Role Level:" + role.level);
            dateManager.LoadDate(role,0);
            Debug.Log("Role Level:" + role.level);
        }
    }
}