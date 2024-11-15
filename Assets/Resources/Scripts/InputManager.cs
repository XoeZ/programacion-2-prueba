using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public enum TypeControls
{
    Keyboard,
    Gamepad
}

public class InputManager : MonoBehaviour
{
    public PlayerInput playerInput;

    public static event System.Action<Vector2> Move;

    public static event System.Action Pause;

    private void OnEnable() => playerInput.onActionTriggered += HandleInput;
    
    private void OnDisable() => playerInput.onActionTriggered -= HandleInput;

    void HandleInput(InputAction.CallbackContext context)
    {
        TryInvokeMove(context);
        TryInvokePause(context);
    }
    private void TryInvokeMove(InputAction.CallbackContext context) 
    {
        if (context.action.name != "Movement") return;

        Vector2 direction = context.ReadValue<Vector2>();
        Move?.Invoke(direction);
    }

    private void TryInvokePause(InputAction.CallbackContext context) 
    {
        if (context.action.name != "Pause") return;
        if (context.canceled) return;
        if (context.performed) return;

        Pause?.Invoke();
    }

}
