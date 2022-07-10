using UnityEngine;

namespace RAFT_HAX;
public class HaxComponents : MonoBehaviour {
    protected virtual void Start() {
        Console.Print($"{this.GetType().Name} started.");
    }
}