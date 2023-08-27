namespace DesignPatternSample.State
{

    public class YellowLight : ILight
    {
        RGYApp RGYApp;
        float time;
        public float Time { get => time; set => time = value; }
        float duration;
        public float Duration { get => duration; set => duration = value; }

        public YellowLight(RGYApp RGYApp)
        {
            this.RGYApp = RGYApp;
            Time = 0;
            Duration = 2;
        }

        public void End()
        {
            UnityEngine.Debug.Log("退出黄灯状态");
        }

        public void Enter()
        {
            UnityEngine.Debug.Log("进入黄灯");
        }

        public void Execute(float dt)
        {
            Time += dt;
            if (Time >= Duration)
            {
                End();
                RGYApp.light = new RedLight(RGYApp);
                RGYApp.light.Enter();
            }
        }
    }

}