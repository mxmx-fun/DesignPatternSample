namespace DesignPatternSample.State
{

    public interface ILight
    {
        float Time { get; set; }
        float Duration { get; set; }
        void Enter();
        void Execute(float dt);
        void End();
    }

}
