namespace DesignPatternSample.Decorator
{

    public class SleepDecorator : CharacterDecorator
    {
        Character character;
        public SleepDecorator(Character character) : base(character)
        {
           
        }

        public override void Action()
        {
            base.Action();
            UnityEngine.Debug.Log("Npc can sleep");
        }
    }
}