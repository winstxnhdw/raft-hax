using Steamworks;

namespace RAFT_HAX;
public class UseCheats : HaxModules {
    CSteamID PlayerSteamID { get; set; }

    protected override void OnEnable() {
        base.OnEnable();

        this.PlayerSteamID = ComponentManager<Network_Player>.Value.steamID;
        RemoteConfigManager.validDevIds.Add(this.PlayerSteamID);
        Cheat.Initialize();
    }
}