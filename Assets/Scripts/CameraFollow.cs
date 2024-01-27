using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    
    void Update()
    {
        if (target != null)
        {


            if (target.position.y > transform.position.y)
            {
                var transform1 = transform;
                var position = transform1.position;
                position = new Vector3(position.x, target.position.y, position.z);
                transform1.position = position;
            }
        }
    }
}
