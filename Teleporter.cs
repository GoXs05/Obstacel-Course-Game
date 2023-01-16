using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] Transform teleportEndTransform;

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Teleported");
            other.transform.position = teleportEndTransform.position;
        }
    }
}
