using UnityEngine;

namespace RAFT_HAX;
public class PaddleMod : HaxModules {
    protected override void OnEnable() {
        base.OnEnable();
        InputListener.onF10Press += this.Paddle;

    }

    protected override void OnDisable() {
        base.OnDisable();
        InputListener.onF10Press -= this.Paddle;
    }

    void Paddle() => ComponentManager<Raft>.Value.AddForce(HaxObjects.LocalPlayerObject.transform.forward, 1000.0f, ForceMode.Impulse, true);

}