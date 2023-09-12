namespace DesignPatternSample.Decorator
{

    public class NpcEntity : Character
    {

        public override void Action()
        {
            UnityEngine.Debug.Log("Npc can walk");
        }
    }
}