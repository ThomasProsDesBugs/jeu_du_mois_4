using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fin : MonoBehaviour

{
    public GameObject Canvas;
    private void OnTriggerEnter (Collider col)

    {
        if(col.name == "First person player")
        {


            Debug.Log("Quit");
            Application.Quit();
        }
    }
}
