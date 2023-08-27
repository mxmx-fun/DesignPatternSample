using UnityEngine;

namespace DesignPatternSample.Facade
{

    public class EngineSystem
    {
        public void Start()
        {
            Debug.Log("EngineSystem Start");
        }

        public void Stop()
        {
            Debug.Log("EngineSystem Stop");
        }

        public bool CheckEngineSystem()
        {
            //检测引擎系统是否正常运作
            return true;
        }

        public void Fire()
        {
            Debug.Log("EngineSystem Fire");
        } 
    }
}
