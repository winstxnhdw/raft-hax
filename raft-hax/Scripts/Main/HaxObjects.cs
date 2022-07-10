namespace RAFT_HAX;
public class HaxObjects : HaxComponents {
    public static ObjectCache<Player> PlayerObject { get; } = new ObjectCache<Player>();

    public static ObjectCache<MeleeWeapon> MeleeWeaponObject { get; } = new ObjectCache<MeleeWeapon>();

    protected override void Start() {
        base.Start();
        HaxObjects.PlayerObject.Init(this);
    }
}