using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public Movement movement;
    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if(collisionInfo.collider.name=="Obstacle1")
        {
            Debug.Log("We hit obstacle1");
        }

    }
}
