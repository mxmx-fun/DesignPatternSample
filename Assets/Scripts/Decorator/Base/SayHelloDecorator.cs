namespace DesignPatternSample.Decorator
{

    public class SayHelloDecorator : CharacterDecorator
    {
        Character character;
        public SayHelloDecorator(Character character) : base(character)
        {
           
        }

        public override void Action()
        {
            base.Action();
            UnityEngine.Debug.Log("Npc can say hello");
        }
    }
}