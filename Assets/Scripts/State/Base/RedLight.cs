namespace DesignPatternSample.State
{
    public class RedLight : ILight
    {
        RGYApp RGYApp;
        float time;
        public float Time { get => time; set => time = value; }
        float duration;
        public float Duration { get => duration; set => duration = value; }

        public RedLight(RGYApp RGYApp)
        {
            this.RGYApp = RGYApp;
            Time = 0;
            Duration = 3;
        }


        public void End()
        {
            UnityEngine.Debug.Log("退出红灯状态");
        }

        public void Enter()
        {
            Time = 0;
            UnityEngine.Debug.Log("进入红灯");
        }

        public void Execute(float dt)
        {
            Time += dt;
            if (Time >= Duration)
            {
                End();
                RGYApp.light = new GreenLight(RGYApp);
                RGYApp.light.Enter();
            }
        }


    }
}
