namespace RAFT_HAX;
public class PersonMod : HaxModules {
    protected override void OnEnable() {
        base.OnEnable();

        PersonController personController = HaxObjects.LocalPlayerObject.GetComponentInChildren<PersonController>();
        personController.swimSpeed = 50.0f;
    }
}