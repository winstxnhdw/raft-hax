namespace RAFT_HAX;
public class MeleeMod : HaxModules {
    protected override void OnEnable() {
        base.OnEnable();
        HaxObjects.MeleeWeaponObject.Init(this);
    }

    protected override void OnDisable() {
        base.OnDisable();
        HaxObjects.MeleeWeaponObject.Stop();
    }

    void Update() {
        MeleeWeapon meleeWeapon = HaxObjects.MeleeWeaponObject.Object;

        if (meleeWeapon == null) return;

        Reflector.Target(meleeWeapon)
                 .SetInternalField("damage", int.MaxValue)
                 .SetInternalField("attackRange", 100.0f);
    }
}