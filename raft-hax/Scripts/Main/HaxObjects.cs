namespace RAFT_HAX;
public class HaxObjects : HaxComponents {
    public static ObjectCache<Player> PlayerObject { get; } = new ObjectCache<Player>();

    public static ObjectsCache<MeleeWeapon> MeleeWeaponObjects { get; } = new ObjectsCache<MeleeWeapon>(0.5f);

    protected override void Start() {
        base.Start();
        HaxObjects.PlayerObject.Init(this);
    }
}