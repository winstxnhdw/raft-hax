
using UnityEngine;

namespace Hax;
public class CursorController : HaxComponents {
    bool CursorLocked { get; set; } = false;

    void Update() {
        this.UnlockCursor();
    }

    void UnlockCursor() {
        if (ConsoleSettings.ShowConsole) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            this.CursorLocked = false;
        }

        else if (!CursorLocked) {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            this.CursorLocked = true;
        }
    }
}