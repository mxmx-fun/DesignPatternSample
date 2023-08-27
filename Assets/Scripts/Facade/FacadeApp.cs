using UnityEngine;

// Facade Pattern (外观模式)
// 主要为外部提供一个统一的接口，隐藏内部的复杂逻辑，降低外部的耦合度。

// 举个例子，现在有个人想开车。车有各个系统，燃油系统，引擎系统，变速系统，电子系统等等。
// 想让车跑起来，需要了解各个系统的运作原理，才能让车跑起来。
// 而外观模式，则好像是方向盘和油门，人只要握住方向盘，踩油门就可以开车。并不需要去了解车内的各个系统如何运作。

namespace DesignPatternSample.Facade
{

    public class FacadeApp : MonoBehaviour
    {

        Car car;

        public void Start()
        {
            car = new Car();
            car.Start();
        }
    }

}
