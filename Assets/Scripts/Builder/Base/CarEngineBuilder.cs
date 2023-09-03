namespace DesignPatternSample.Builder
{
    public enum CarEngine
    {
        V6,
        V8,
        V12
    }

    public class CarEngineBuilder
    {
        public void BuildCarEngine(CarEngine carEngine, CarEntity car)
        {
            switch (carEngine)
            {
                //这里可能有引擎盖打开，引擎安装，引擎盖关闭等等操作，这边就忽略，直接进行属性设置了
                case CarEngine.V6:
                    car.Engine = CarEngine.V6;
                    break;
                case CarEngine.V8:
                    car.Engine = CarEngine.V8;
                    break;
                case CarEngine.V12:
                    car.Engine = CarEngine.V12;
                    break;
                default:
                    car.Engine = CarEngine.V6;
                    break;
            }

        }
    }
}