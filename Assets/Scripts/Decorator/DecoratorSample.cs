using UnityEngine;

namespace DesignPatternSample.Decorator
{

    public class DecoratorSample : MonoBehaviour
    {
        public void Awake() {
            Character character = new NpcEntity();
            character.Action();
            character = new SleepDecorator(character);
            character.Action();
            character = new SayHelloDecorator(character);
            character.Action();
        }

    }
}