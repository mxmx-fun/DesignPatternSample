using UnityEngine;

namespace DesignPatternSample.Facade
{

    public class TransmissionSystem
    {
        public void Start()
        {
            Debug.Log("TransmissionSystem Start");
        }

        public void Stop()
        {
            Debug.Log("TransmissionSystem Stop");
        }

        public void GoForward(int speed, int time)
        {
            var distance = speed * time;
            Debug.Log("TransmissionSystem GoForward " + distance + "m");
        }
    }
}