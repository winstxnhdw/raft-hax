using UnityEngine;

namespace RAFT_HAX;
public class Loader : MonoBehaviour {
    static GameObject HaxGameObject { get; } = new GameObject();
    public static GameObject HaxModules { get; } = new GameObject();
    public static GameObject HaxStealthModules { get; } = new GameObject();

    static void AddHaxModules<T>() where T : Component => Loader.HaxModules.AddComponent<T>();
    static void AddHaxGameObject<T>() where T : Component => Loader.HaxGameObject.AddComponent<T>();

    public static void Load() {
        Loader.LoadHaxGameObjects();
        Loader.LoadHaxModules();
    }

    static void LoadHaxGameObjects() {
        DontDestroyOnLoad(Loader.HaxGameObject);

        AddHaxGameObject<InputListener>();
        AddHaxGameObject<Console>();
    }

    static void LoadHaxModules() {
        DontDestroyOnLoad(Loader.HaxModules);

        AddHaxModules<EnableCheat>();
    }

    public static void Unload() {
        Destroy(Loader.HaxModules);
        Destroy(Loader.HaxGameObject);
    }
}
