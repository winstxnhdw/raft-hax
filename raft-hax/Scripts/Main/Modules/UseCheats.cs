using Steamworks;

namespace Hax;
public class UseCheats : HaxModules {
    protected override void OnEnable() {
        base.OnEnable();

        RemoteConfigManager.validDevIds.Add(ComponentManager<Network_Player>.Value.steamID);
        Cheat.Initialize();
    }
}
