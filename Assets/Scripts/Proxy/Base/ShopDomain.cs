using UnityEngine;

namespace DesignPatternSample.Proxy
{
    public class ShopDomain
    {

        ItemShop shop;

        public ShopDomain()
        {
            shop = new ItemShop();
        }

        public void SellItem(RoleEntity role, string itemName)
        {
            Item item = shop.GetItem(itemName);
            if (item == null)
            {
                Debug.Log("当前游戏没有这个物品");
                return;
            }

            if (!role.HaveItem(item))
            {
                Debug.Log("玩家没有这个物品");
                return;
            }
            role.itemList.Remove(item);
            role.coin += item.Price;
            Debug.Log($"SellItem:{item.Name}");
        }

        public void BuyItem(RoleEntity role, string itemName)
        {
            Item item = shop.GetItem(itemName);
            if (item == null)
            {
                Debug.Log("当前游戏商店没有这个物品");
                return;
            }

            if (role.coin < item.Price)
            {
                Debug.Log("玩家金币不足无法购买");
                return;
            }
            role.itemList.Add(item);
            role.coin -= item.Price;
            Debug.Log($"BuyItem:{item.Name}");
        }
    }
}