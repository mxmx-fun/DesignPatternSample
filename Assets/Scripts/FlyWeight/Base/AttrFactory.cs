using System.Collections.Generic;

namespace DesignPatternSample.FlyWeight
{
    public class AttrFactory
    {
        public Dictionary<int, AttrParam> AttrDic;
        public AttrFactory() 
        {
            AttrDic = new Dictionary<int, AttrParam>();
            AttrDic.Add(1, new AttrParam(1, "Warrior", 10, 10, 100, 10, 5, 5, 50, 1));
            AttrDic.Add(2, new AttrParam(2, "Wizard", 20, 5, 50, 12, 10, 2, 20, 2));
        }

        public AttrParam GetAttrParam(int id) 
        {
            AttrParam attr;
            if(AttrDic.ContainsKey(id)) 
            {
                attr = AttrDic[id];
            } else {
                attr = new AttrParam();
                UnityEngine.Debug.LogError("AttrParam not found");
            }
            return attr;
        }
    }
}
