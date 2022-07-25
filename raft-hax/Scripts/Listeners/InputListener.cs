using System;
using System.Collections.Generic;
using UnityEngine;

namespace RAFT_HAX;
public class InputListener : HaxComponents {
    public static event Action onF10Press;
    public static event Action onPausePress;
    public static event Action onEscapePress;

    Dictionary<Func<bool>, Action> keyActionsDict = new Dictionary<Func<bool>, Action>() {
        {() => Input.GetKeyDown(KeyCode.BackQuote),   () => Console.ShowConsole()},
        {() => Input.GetKeyDown(KeyCode.F10),         () => InputListener.onF10Press()},
        {() => Input.GetKeyDown(KeyCode.Pause),       () => InputListener.onPausePress?.Invoke()},
        {() => Input.GetKeyDown(KeyCode.Escape),      () => InputListener.onEscapePress?.Invoke()},

    };

    void Update() {
        this.KeyboardListener();
    }

    void KeyboardListener() {
        foreach (KeyValuePair<Func<bool>, Action> keyAction in this.keyActionsDict) {
            if (!(keyAction.Key())) continue;
            keyAction.Value();
        }
    }
}