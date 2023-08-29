using DesignPatternSample.Facade;

namespace DesignPatternSample.Mediator
{
    public class MediatorSample
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