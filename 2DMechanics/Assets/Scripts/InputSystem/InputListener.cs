using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputListener : MonoBehaviour
{
    private MainControl inputActions;
    private Rigidbody2D rb;
    [SerializeField] private PlayerMovement player;
    void Awake()
    {
        inputActions = new();
        inputActions.Player.Move.performed += Move;
        inputActions.Enable();
    }

    private void Move(InputAction.CallbackContext context)
    {
        var inputValue = context.ReadValue<Vector2>().normalized;
        player.Move(inputValue);
    }
}
