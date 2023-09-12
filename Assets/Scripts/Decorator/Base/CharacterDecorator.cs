namespace DesignPatternSample.Decorator
{

    public class CharacterDecorator : Character
    {
        Character character;

        public CharacterDecorator(Character character)
        {
            this.character = character;
        }

        public override void Action()
        {
            character.Action();
        }
    }
}