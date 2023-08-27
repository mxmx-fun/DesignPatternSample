using UnityEngine;

// Facade Pattern (外观模式)
// 主要为外部提供一个统一的接口，隐藏内部的复杂逻辑，降低外部的耦合度。

// 举个例子，现在有个人想让车往前跑10m
// 而想让车跑起来，需要点火引擎，挂N档，然后踩油门等等。
// 而外观模式，就好像傻瓜操作。忽略掉上述的一系列操作，你只需要知道启动车的接口。调用就可以让车直接跑10m，不用管中间的过程。

//总结:
//外观模式，是外部调用一个系统功能，不用去管内部用了哪几个功能。只需要调用外观类的接口即可。
//个人理解：Controller层
namespace DesignPatternSample.Facade
{

    public class FacadeApp : MonoBehaviour
    {

        Car car;
        CarController controller;
        public void Start()
        {
            car = new Car();
            controller = new CarController();
            controller.CarMove(car);
        }
    }

}
