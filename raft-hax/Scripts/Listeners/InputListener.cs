using System;
using System.Collections.Generic;
using UnityEngine;

namespace RAFT_HAX;
public class InputListener : HaxComponents {
    public static event Action onEscapePress;

    Dictionary<Func<bool>, Action> keyActionsDict = new Dictionary<Func<bool>, Action>() {
        {() => Input.GetKey(KeyCode.F9), () => MyInput.GetButtonDown("Noclip")},
        {() => Input.GetKeyDown(KeyCode.BackQuote),   () => Console.ShowConsole()},
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