using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEditor.Animations;

public class NPC_doc : MonoBehaviour
{
    public TextMeshProUGUI talk;
    public Rigidbody2D rb;
    public Animator animator;
    public float time = 0;
    public float dir = 5;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            talk.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            talk.gameObject.SetActive(false);
        }
    }
}
