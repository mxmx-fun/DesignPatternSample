namespace DesignPatternSample.Command
{

    public enum SoldierType
    {
        Soldier,
        Wizard
    }

    public class CreateSoldierCommand : ICommand
    {

        int level;
        int count;
        SoldierType type;

        public CreateSoldierCommand(int level, int Count, SoldierType type)
        {
            this.level = level;
            this.count = Count;
            this.type = type;
        }

        public void Execute()
        {
            //根据参数模拟造兵
            UnityEngine.Debug.Log($"CreateSoldier:{type}");
        }
    }
}