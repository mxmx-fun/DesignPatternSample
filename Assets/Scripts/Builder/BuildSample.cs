using UnityEngine;

namespace DesignPatternSample.Builder {

    public class BuildSample:MonoBehaviour {

        CarFactory carFactory;
        public void Start() {
            carFactory = new CarFactory();
            CarEntity car = carFactory.CreateCar(CarColor.Red, CarEngine.V6, CarTyre.Michelin);
            Debug.Log("Car Color:" + car.Color + " Car Engine:" + car.Engine + " Car Tyre:" + car.Tyre);
        }
    }
}