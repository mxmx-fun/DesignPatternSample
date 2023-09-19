using UnityEngine;
using DesignPatternSample.FlyWeight;
using System.Collections.Generic;

namespace DesignPatternSample.Filter
{

    public class FilterSample : MonoBehaviour
    {

        void Start()
        {
            //创建角色
            RoleEntity role1 = new RoleEntity();
            role1.currentHp = 100;
            role1.maxHp = 200;
            RoleEntity role2 = new RoleEntity();
            role2.currentHp = 20;
            role2.maxHp = 100;
            RoleEntity role3 = new RoleEntity();
            role3.currentHp = 100;
            role3.maxHp = 300;

            //创建角色列表
            List<RoleEntity> roleList = new List<RoleEntity>();
            roleList.Add(role1);
            roleList.Add(role2);
            roleList.Add(role3);

            //创建过滤器
            IFilter<RoleEntity> filter = new CharacterFilter();
            //过滤
            List<RoleEntity> result = filter.Filter(roleList);
            //打印
            foreach (var role in result)
            {
                Debug.Log(role);
            }
        }
    }
}