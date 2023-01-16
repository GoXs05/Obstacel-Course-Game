using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    int rotateSpeed = 65;

    // Update is called once per frame
    void Update()
    {
        rotate();
    }

    void rotate()
    {
        float xRotation = 0f * Time.deltaTime * rotateSpeed;
        float yRotation = 2f * Time.deltaTime * rotateSpeed;
        float zRotation = 0f * Time.deltaTime * rotateSpeed;

        transform.Rotate(xRotation, yRotation, zRotation);
    }
}
