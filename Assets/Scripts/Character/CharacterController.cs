using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;

    public void CallMoveEvent(Vector2 diretion)
    {
        OnMoveEvent?.Invoke(diretion);
    }
}
