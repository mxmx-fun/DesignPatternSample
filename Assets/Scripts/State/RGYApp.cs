using DesignPatternSample.Singleton;
using UnityEngine;

// State Pattern(状态模式)
// 状态模式主要是为了解决大量的if else判断，将各个状态的逻辑分离出来，降低耦合度。
// 举个例子，现在有个交通灯，有红灯，黄灯，绿灯三种状态。
// 如果不用状态模式，就是if else判断，每个状态的逻辑都在一起，不好维护。
// 而状态模式，则是将每个状态的逻辑分离出来，每个状态都是一个类，这样就可以很好的维护了。
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