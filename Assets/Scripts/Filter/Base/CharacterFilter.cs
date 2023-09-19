using System.Collections.Generic;
using DesignPatternSample.FlyWeight;

namespace DesignPatternSample.Filter
{
    public class CharacterFilter : IFilter<RoleEntity>
    {

        //查找血量低于百分之五十的角色
        public List<RoleEntity> Filter(List<RoleEntity> roleList)
        {
            List<RoleEntity> result = new List<RoleEntity>();
            foreach (var role in roleList)
            {
                if (role.currentHp < role.maxHp * 0.5f)
                {
                    result.Add(role);
                }
            }
            return result;
        }
    }
}