namespace RAFT_HAX;
public class PersonMod : HaxModules {
    protected override void OnEnable() {
        base.OnEnable();

        PersonController personController = HaxObjects.LocalPlayerObject.GetComponentInChildren<PersonController>();
        personController.swimSpeed = 50.0f;
        personController.normalSpeed = personController.sprintSpeed;
        personController.sprintSpeed = 12.0f;
    }
}