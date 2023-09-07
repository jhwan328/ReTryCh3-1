using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;
public class SpawnManager : MonoBehaviour
{
    public AnimatorController knightAnimatorController;
    public AnimatorController elfAnimatorController;

    public enum CharacterClass
    {
        Knight,
        Elf
    }

    public GameObject CharacterPrefab;

    public Character SpawnPlayer(string name, int num)
    {
        Camera cam = Camera.main;
        CameraFollow camFollow = cam.GetComponent<CameraFollow>();
        GameObject player = Instantiate(CharacterPrefab);
        Character playerScript= player.GetComponent<Character>();
        Animator animator = player.GetComponent<Animator>();

        if (playerScript != null)
        {
            playerScript.SetState(name, num);
            if(num == 0)
            {
                animator.runtimeAnimatorController = knightAnimatorController;
            }
            else
            {
                animator.runtimeAnimatorController = elfAnimatorController;
            }
 
        }
        camFollow.SetTarget(player);
        return playerScript;
    }
}
