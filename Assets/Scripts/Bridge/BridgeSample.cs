using DesignPatternSample.Strategy;
using UnityEngine;

namespace DesignPatternSample.Bridge
{
    public class BridgeSample : MonoBehaviour
    {
        void Start()
        {
            RoleEntity role = new RoleEntity(new Wizard(), new Gun(), new WarriorDmgStrategy(), 1);
            int dmg = role.GetDamage();
            Debug.Log("damage: " + dmg);
            role.Attack();
        }


    }

}

