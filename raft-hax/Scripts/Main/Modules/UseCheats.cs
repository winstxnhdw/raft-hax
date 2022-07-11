using Steamworks;

namespace RAFT_HAX;
public class UseCheats : HaxModules {
    CSteamID SteamID { get; set; }

    protected override void OnEnable() {
        base.Start();
        InputListener.onF9Press += this.ToggleNuke;
        this.SteamID = ComponentManager<Network_Player>.Value.steamID;
        RemoteConfigManager.validDevIds.Add(this.SteamID);
        Cheat.Initialize();
    }

    protected override void OnDisable() {
        base.OnDisable();
        InputListener.onF9Press -= this.ToggleNuke;
    }

    void ToggleNuke() {
        Cheat.HandleCheatCode("nuke", ",", this.SteamID);
    }
}