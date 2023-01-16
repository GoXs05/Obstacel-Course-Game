using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    float Y_CONST = 0f;
    float moveSpeed = 10f;

    Collider collider;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Wall")
        {
            moveSpeed = 10f;
            collider.isTrigger = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        ShiftDown();
        MovePlayer();
        ShiftUp();
    }

    void PrintInstructions() 
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move your player with WASD or the arrow keys.");
        Debug.Log("Dash through objects with left shift");
        Debug.Log("Don't hit the yellow obstacles!");
        Debug.Log("Objects that you have hit turn red and cannot add to your score if you hit them again.");
    }

    void MovePlayer() 
    {
        collider = GetComponent<Collider>();
        
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        
        transform.Translate(xValue, Y_CONST, zValue);
    }

    void ShiftDown()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed *= 45;
            collider.isTrigger = true;
        }
    }

    void ShiftUp()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed /= 45;
            collider.isTrigger = false;
        }
    }
}
