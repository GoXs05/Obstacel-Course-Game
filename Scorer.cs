using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision other) 
    {
        if ((other.gameObject.tag != "Hit") && ((other.gameObject.tag != "Finish") && (other.gameObject.tag != "Wall") && (other.gameObject.tag != "Teleport")))
        {
            hits++;
            Debug.Log("Hits: " + hits);
        }
        
        if ((other.gameObject.tag == "Finish"))
        {
            Debug.Log("Final Score: " + hits);
        }
    }
}
