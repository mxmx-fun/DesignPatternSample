using UnityEngine;

namespace DesignPatternSample.Facade
{
    
    public class FuelSystem
    {
        float fuel;

        public FuelSystem()
        {
            fuel = 100;
        }

        public void Start()
        {
            Debug.Log("FuelSystem Start");
        }

        public void Stop()
        {
            Debug.Log("FuelSystem Stop");
        }

        public bool CheckFuelSystem()
        {
            //检测燃油系统是否正常运作
            return true;
        }

        public float GetFuel()
        {
            return fuel;
        }

        public void ConsumeFuel(float value)
        {
            //消耗燃油
            fuel -= value;
        }
    }


}