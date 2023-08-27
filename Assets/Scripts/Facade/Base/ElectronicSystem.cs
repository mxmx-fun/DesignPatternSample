using UnityEngine;

namespace DesignPatternSample.Facade
{

    public class ElectronicSystem
    {
        float electricity;

        public void Start()
        {
            Debug.Log("ElectronicSystem Start");
        }

        public void Stop()
        {
            Debug.Log("ElectronicSystem Stop");
        }

        public void GenerateElectricity(float value)
        {
            //产生电力
            electricity += value;
        }

        public void ConsumeElectricity(float value)
        {
            //消耗电力
            electricity -= value;
        }
    }
}