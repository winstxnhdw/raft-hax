using Steamworks;

namespace RAFT_HAX;
public class UseCheats : HaxModules {
    CSteamID PlayerSteamID { get; set; }

    protected override void OnEnable() {
        base.Start();
        InputListener.onF9Press += this.ToggleNuke;
        this.PlayerSteamID = ComponentManager<Network_Player>.Value.steamID;
        RemoteConfigManager.validDevIds.Add(this.PlayerSteamID);
        Cheat.Initialize();
    }

    protected override void OnDisable() {
        base.OnDisable();
        InputListener.onF9Press -= this.ToggleNuke;
    }

    void ToggleNuke() {
        Cheat.HandleCheatCode("nuke", ",", this.PlayerSteamID);
    }
}