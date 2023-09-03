namespace DesignPatternSample.Builder
{
    public enum CarColor
    {
        Red,
        Blue,
        Green
    }

    public class CarColorBuilder
    {
        //处理车的颜色
        public void BuildCarColor(CarColor carColor, CarEntity car)
        {
            switch (carColor)
            {
                case CarColor.Red:
                    //这里可能有车辆喷漆，贴膜等等操作，这边就忽略，直接进行属性设置了
                    car.Color = CarColor.Red;
                    break;
                case CarColor.Blue:
                    car.Color = CarColor.Blue;
                    break;
                case CarColor.Green:
                    car.Color = CarColor.Green;
                    break;
                default:
                    car.Color = CarColor.Red;
                    break;
            }

        }
    }
}