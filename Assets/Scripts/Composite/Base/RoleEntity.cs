using System.Collections.Generic;

namespace DesignPatternSample.Composite {
    public class RoleEntity {

        int combatEffectiveness;

        List<ICombatEffectiveness> _combatEffectivenessList;

        public RoleEntity() {
            _combatEffectivenessList = new List<ICombatEffectiveness>();
            AddCombatEffectiveness(new AttrComponent());
            AddCombatEffectiveness(new WeaponComponent());
            AddCombatEffectiveness(new PetComponent());
        }

        public void AddCombatEffectiveness(ICombatEffectiveness combatEffectiveness) {
            _combatEffectivenessList.Add(combatEffectiveness);
        }

        public void RemoveCombatEffectiveness(ICombatEffectiveness combatEffectiveness) {
            _combatEffectivenessList.Remove(combatEffectiveness);
        }

        public void GetCombatEffectiveness() {
            combatEffectiveness = 0;
            foreach (var item in _combatEffectivenessList) {
                combatEffectiveness += item.GetCombatEffectiveness();
            }
            UnityEngine.Debug.Log("角色战斗力：" + combatEffectiveness);
        }

    }
}