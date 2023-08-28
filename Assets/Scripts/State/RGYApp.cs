using DesignPatternSample.Singleton;
using UnityEngine;

namespace DesignPatternSample.State
{

    public class RGYApp : MonoBehaviour
    {
        public new ILight light;

        public void Start()
        {
            light = new RedLight(this);
            light.Enter();
        }

        public void Update()
        {
            var dt = Time.deltaTime;
            light.Execute(dt);
        }
    }
}