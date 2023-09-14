using System.Collections.Generic;
using UnityEngine;

namespace DesignPatternSample.Proxy {
    public class ItemShop {

        public Dictionary<string, Item> ItemList { get; set; }

        public ItemShop() {
            ItemList = new Dictionary<string, Item>();
            ItemList.Add("小红药水", new Item("小红药水", 100));
            ItemList.Add("中红药水", new Item("中红药水", 200));
            ItemList.Add("大红药水", new Item("大红药水", 300));
            ItemList.Add("金疮药", new Item("金疮药", 400));
            ItemList.Add("妙手回春", new Item("妙手回春", 500));
        }

        public void AddItem(Item item) {
            if(ItemList.ContainsKey(item.Name)) {
                Debug.LogError("已经有这个物品");
                return;
            }
            ItemList.Add(item.Name, item);
        }

        public void CloseShop() {
            Debug.Log("CloseShop");
        }

        public void OpenShop() {
            Debug.Log("OpenShop");
        }

        public Item GetItem(string name) {
            if(!ItemList.ContainsKey(name)) {
                Debug.LogError("没有这个物品");
                return null;
            }
            return ItemList[name];
        }


    }
}