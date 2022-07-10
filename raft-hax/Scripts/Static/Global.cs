using UnityEngine;

namespace RAFT_HAX;
public static class Global {
    public static void SetActiveGameObject(GameObject go, bool isActive) {
        if (go.activeSelf == isActive) return;
        go.SetActive(isActive);
    }
}