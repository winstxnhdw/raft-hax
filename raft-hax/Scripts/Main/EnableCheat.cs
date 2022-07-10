namespace RAFT_HAX;
public class EnableCheat : HaxModules {
    void Update() {
        Cheat.UseCheats = true;
        MeleeWeapon meleeWeapon = FindObjectOfType<MeleeWeapon>();
        Reflector.Target(meleeWeapon)
                 .SetInternalField("damage", int.MaxValue)
                 .SetInternalField("attackRange", 100.0f);
    }
}