using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private CharacterController _controller;
   // private Animator _animator;
    private Vector2 _movemetDirection = Vector2.zero;
    private Rigidbody2D rb;
    public float MoveSpeed;
    public float CalSpeed = 5;
    public Character Character;
    public Animator animator;
  
    private void Awake()
    {
        //_animator = GetComponentInChildren<Animator>();
        _controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody2D>();
        Character=GetComponent<Character>();
        animator = GetComponent<Animator>();
      
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }
    private void FixedUpdate()
    {
        ApplyMovement(_movemetDirection);
    }
    private void Move(Vector2 direction)
    {
        _movemetDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction *= CalSpeed;
        MoveSpeed = direction.sqrMagnitude;
        if(MoveSpeed > 10.0f)
        {
            animator.SetTrigger("Run");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
        rb.velocity = direction;
    }
}
