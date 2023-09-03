namespace DesignPatternSample.Builder
{
    public enum CarTyre
    {
        Michelin,
        Pirelli,
        Bridgestone
    }

    public class CarTyreBuilder
    {
        //处理车的轮胎
        public void BuildCarTyre(CarTyre carTyre, CarEntity car)
        {
            switch (carTyre)
            {
                case CarTyre.Michelin:
                    //这里可能有轮胎安装，轮胎充气等等操作，这边就忽略，直接进行属性设置了
                    car.Tyre = CarTyre.Michelin;
                    break;
                case CarTyre.Pirelli:
                    car.Tyre = CarTyre.Pirelli;
                    break;
                case CarTyre.Bridgestone:
                    car.Tyre = CarTyre.Bridgestone;
                    break;
                default:
                    car.Tyre = CarTyre.Michelin;
                    break;
            }
        }

    }
}