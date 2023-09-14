using UnityEngine;

namespace DesignPatternSample.Proxy
{
    public class ProxySample : MonoBehaviour
    {
        public void Awake()
        {
            RoleEntity role = new RoleEntity();
            ShopDomain shop = new ShopDomain();
            role.ShowInfo();
            shop.BuyItem(role, "Sword");
            shop.BuyItem(role, "妙手回春");
            role.ShowInfo();
            shop.SellItem(role, "妙手回春");
            role.ShowInfo();
        }
    }
}