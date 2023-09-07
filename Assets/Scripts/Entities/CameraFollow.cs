using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    public float height = -8.0f;
   
    public void Update()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.transform.position;
            this.transform.position = new Vector3(targetPosition.x,targetPosition.y, height);
        }
    }
    // Update is called once per frame
   public void SetTarget(GameObject target)
    {
        this.target = target;
    }
}
