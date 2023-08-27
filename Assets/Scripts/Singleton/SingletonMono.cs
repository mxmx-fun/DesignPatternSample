using UnityEngine;

namespace DesignPatternSample.Singleton
{

    public class SingletonMono<T> where T:MonoBehaviour
    {

        private static T instance;
        public static T Instance
        {
            get
            {
                return instance;
            }
        }

        public void Awake()
        {
            instance = this as T;
        }
    }


}