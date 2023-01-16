using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{

    [SerializeField] GameObject UIObj;
    [SerializeField] Transform startPos;
    [SerializeField] Transform player;

    Scene scene;


    void Start()
    {
        UIObj.SetActive(false);
        scene = SceneManager.GetActiveScene();
    }


    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Player")
        {
            UIObj.SetActive(true);
            StartCoroutine(RestartDelay());
        }
    }


    private IEnumerator RestartDelay()
    {
        yield return new WaitForSeconds(3f);
        UIObj.SetActive(false);
        //player.position = startPos.position;
        SceneManager.LoadScene(scene.name);
    }

}
