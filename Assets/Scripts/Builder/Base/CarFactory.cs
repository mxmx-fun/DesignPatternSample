namespace DesignPatternSample.Builder
{

    public class CarFactory
    {

        CarColorBuilder colorBuilder;
        CarEngineBuilder engineBuilder;
        CarTyreBuilder tyreBuilder;

        public CarFactory()
        {
            colorBuilder = new CarColorBuilder();
            engineBuilder = new CarEngineBuilder();
            tyreBuilder = new CarTyreBuilder();
        }

        //建造者模式的思想，其实是将流程与实现进行分离。这样流程不管怎么改变，实现也不会受影响。
        //你也可以在工厂模式里，将具体实现进行分离。但那样工厂类，就会变得很臃肿，不好维护。
        public CarEntity CreateCar(CarColor color, CarEngine engine, CarTyre tyre)
        {
            CarEntity car = new CarEntity();
            colorBuilder.BuildCarColor(color, car);
            engineBuilder.BuildCarEngine(engine, car);
            tyreBuilder.BuildCarTyre(tyre, car);
            return car;
        }
    }
}