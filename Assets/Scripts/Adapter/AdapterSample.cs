using UnityEngine;

namespace DesignPatternSample.Adapter {

    public class AdapterSample:MonoBehaviour {

        public void Awake() {
            PetEntity pet = new PetEntity();
            pet.Action();
            pet.Attri();
        }
    }
}