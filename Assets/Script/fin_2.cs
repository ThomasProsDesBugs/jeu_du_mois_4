using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fin_2 : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject videoPlayer;

    void quit()
    {
        Debug.Log("Quit2");
        Application.Quit();
    }
    private void OnTriggerEnter(Collider col)

    {
       
        if (col.name == "First person player")
        {
            videoPlayer.SetActive(true);
            Invoke("quit", 7);
            

        }

      
    }
}
