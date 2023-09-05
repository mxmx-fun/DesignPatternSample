using UnityEngine;

namespace DesignPatternSample.Composite {

    public class CompositeSample:MonoBehaviour {

        void Start() {
            RoleEntity role = new RoleEntity();
            role.GetCombatEffectiveness();
        }
    }
}