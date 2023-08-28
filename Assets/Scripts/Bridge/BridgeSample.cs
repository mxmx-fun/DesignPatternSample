using UnityEngine;

namespace DesignPatternSample.Bridge
{
    public class BridgeSample : MonoBehaviour
    {
        void Start()
        {
            RoleEntity role = new RoleEntity(new Warrior(), new Gun(), 1);
            role.Attack();
        }


    }

}

