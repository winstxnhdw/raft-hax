namespace RAFT_HAX;
public class UseCheats : HaxModules {
    protected override void OnEnable() {
        base.Start();
        Cheat.UseCheats = true;
    }
}