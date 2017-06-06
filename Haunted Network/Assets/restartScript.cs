using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class restartScript : MonoBehaviour
{

    public Image essay;
    public Image email;
    public Image eee;
    public Image restart;
    public Image virusAlert;
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
                restart.enabled = false;
                email.enabled = true;
                virusAlert.enabled = true;
                restartTimer = 0;
                GameObject gameMaster = GameObject.Find("GameMaster");
                Tabs tabs = gameMaster.GetComponent<Tabs>();
                tabs.sceneNumber = 2;
            }
        }
    }
}