using System.Collections.Generic;

namespace DesignPatternSample.Proxy
{

    public class RoleEntity
    {

        public int coin;
        public List<Item> itemList;

        public RoleEntity()
        {
            coin = 1000;
            itemList = new List<Item>();
        }

        public bool HaveItem(Item item)
        {
            return itemList.Contains(item);
        }

        public void ShowInfo()
        {
            UnityEngine.Debug.Log($"当前玩家金币:{coin}");
            if (itemList.Count == 0)
            {
                UnityEngine.Debug.Log("当前背包没有物品");
                return;
            }

            foreach (Item item in itemList)
            {
                UnityEngine.Debug.Log($"当前背包有物品:{item.Name}");
            }
        }
    }
}