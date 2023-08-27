using DesignPatternSample.Facade;

// Mediator Pattern(中介者模式)
// 用于内部之间的交互，将复杂的内部交互简化，使得各个子系统之间的交互不会相互影响。
// 用一个中介对象来封装一系列的对象交互，中介者使各个对象不需要显式地相互引用。

//举个例子，汽车的启动过程，需要燃油系统、电子系统、引擎系统、变速系统等各个子系统的配合，
//如果不使用中介者模式，那么各个子系统之间的交互会非常复杂，而且各个子系统之间的交互会相互影响。
//就比如引擎点火，你可能就会把燃油系统的燃油在引擎系统进行消耗。就变得各个类不遵守单一职责原则。
//使用中介者模式，可以将复杂的交互简化，各个子系统之间的交互也不会相互影响。

//总结:
//中介者模式是一个系统里内部交互解耦的一种设计模式。
//个人理解：Domain层
namespace DesignPatternSample.Mediator
{
    public class CarDomain
    {

        //启动汽车
        public void On(Car car)
        {
            float fuel = car.FuelSystem.GetFuel();
            if (fuel >= 60)
            {
                car.FuelSystem.ConsumeFuel(60);
                car.ElectronicSystem.GenerateElectricity(60);
                car.ElectronicSystem.ConsumeElectricity(60);
                car.EngineSystem.Fire();
            }
        }

        public void Off(Car car)
        {
            car.EngineSystem.Stop();
            car.TransmissionSystem.Stop();
            car.ElectronicSystem.Stop();
            car.FuelSystem.Stop();
        }

        public void GoForward(Car car, int speed, int time)
        {
            car.TransmissionSystem.GoForward(speed,time);
            var distance = speed * time;
            var cost = distance * 0.1f;
            car.FuelSystem.ConsumeFuel(cost);
            car.ElectronicSystem.GenerateElectricity(cost);
            car.ElectronicSystem.ConsumeElectricity(cost);
        }
    }
}