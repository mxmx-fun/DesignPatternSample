using System.Collections.Generic;

namespace DesignPatternSample.Memento
{
    public class DateManager
    {
        public Dictionary<int, GameDate> gameDateDic;

        public DateManager()
        {
            gameDateDic = new Dictionary<int, GameDate>();
        }

        GameDate SaveDate(RoleEntity role)
        {
            GameDate gameDate = new GameDate(role.coin, role.level, role.diamond);
            return gameDate;
        }

        public void SaveDate(RoleEntity role, int dateIndex)
        {
            GameDate gameDate = SaveDate(role);
            gameDateDic.Add(dateIndex, gameDate);
        }

        public void LoadDate(RoleEntity role, int dateIndex)
        {
            if (gameDateDic.ContainsKey(dateIndex))
            {
                GameDate gameDate = gameDateDic[dateIndex];
                role.coin = gameDate.coin;
                role.level = gameDate.level;
                role.diamond = gameDate.diamond;
            }
        }
    }
}