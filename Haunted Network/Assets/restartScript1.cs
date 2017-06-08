using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restartScript1 : MonoBehaviour
{
    public Image restart;
    public int restartTimer;


    public int sceneNumber;

    // Use this for initialization
    void Start()
    {
        restartTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (restart.enabled == true)
        {
            if (restartTimer <= 400)
            {
                restartTimer++;
            }
            else
            {
                SceneManager.LoadScene("Scene3");
            }
        }
    }
}