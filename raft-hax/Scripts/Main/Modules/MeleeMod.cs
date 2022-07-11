namespace RAFT_HAX;
public class MeleeMod : HaxModules {
    protected override void OnEnable() {
        base.OnEnable();
        HaxObjects.MeleeWeaponObjects.Init(this);
    }

    protected override void OnDisable() {
        base.OnDisable();
        HaxObjects.MeleeWeaponObjects.Stop();
    }

    void Update() {
        foreach (MeleeWeapon meleeWeapon in HaxObjects.MeleeWeaponObjects.Objects) {
            Reflector.Target(meleeWeapon)
                     .SetInternalField("damage", int.MaxValue)
                     .SetInternalField("attackRange", 100.0f);
        }
    }
}