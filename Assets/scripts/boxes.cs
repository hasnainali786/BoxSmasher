using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxes : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag=="ball")
        {

         gameObject.GetComponent<Rigidbody>().AddForceAtPosition(Vector3.forward*50f,Vector3.forward, ForceMode.VelocityChange);
        }
    }
}
