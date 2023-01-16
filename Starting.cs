using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starting : MonoBehaviour
{

    [SerializeField] GameObject StartingInstructions;

    void Start()
    {
        StartingInstructions.SetActive(true);
        StartCoroutine(InstructionsDisappear());
    }


    IEnumerator InstructionsDisappear()
    {
        yield return new WaitForSeconds(7f);
        StartingInstructions.SetActive(false);
    }
}
