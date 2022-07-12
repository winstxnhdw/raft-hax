namespace RAFT_HAX;
public class MeleeMod : HaxModules {
    void Update() {
        foreach (MeleeWeapon meleeWeapon in HaxObjects.LocalPlayerObject.GetComponentsInChildren<MeleeWeapon>()) {
            if (meleeWeapon == null) continue;

            Reflector.Target(meleeWeapon)
                     .SetInternalField("damage", int.MaxValue)
                     .SetInternalField("attackRange", 100.0f);
        }
    }
}