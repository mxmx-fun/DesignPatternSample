using UnityEngine;

namespace DesignPatternSample.FlyWeight
{

    public class FlyWeightSample : MonoBehaviour
    {

        public AttrFactory attrFactory;
        public void Start()
        {
            attrFactory = new AttrFactory();

            RoleEntity role = new RoleEntity();
            AttrParam attr = attrFactory.GetAttrParam(1);
            role.SetBaseAttr(attr);
            role.level = 1;
            role.InitAttr();
            Debug.Log("Role Name:" + role.baseAttr.name + " Role Level:" + role.level + " Role Hp:" + role.currentHp + " Role Atk:" + role.currentAtk + " Role Def:" + role.currentDef + " Role Spd:" + role.currentSpd);
        }
    }
}