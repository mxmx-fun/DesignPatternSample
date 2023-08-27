using DesignPatternSample.Mediator;

namespace DesignPatternSample.Facade
{

    public class CarController
    {
        CarDomain domain;

        public CarController()
        {
            domain = new CarDomain();
        }

        public void CarMove(Car car)
        {
            domain.On(car);
            domain.GoForward(car, 10, 10);
            domain.Off(car);
        }
    }

}