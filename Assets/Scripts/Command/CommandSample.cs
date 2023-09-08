using System.Collections.Generic;
using UnityEngine;

namespace DesignPatternSample.Command {

    public class CommandSample:MonoBehaviour {

        public Queue<ICommand> commands = new Queue<ICommand>();

        void Start() {
            //模拟网络端传来两条指令
            commands.Enqueue(new CreateSoldierCommand(1, 10, SoldierType.Soldier));
            commands.Enqueue(new CreateSoldierCommand(1, 10, SoldierType.Wizard));
        }

        void Update() {
            //模拟事件中心，每帧执行一条指令
            if(commands.Count > 0) {
                commands.Dequeue().Execute();
            }
        }
    }
}