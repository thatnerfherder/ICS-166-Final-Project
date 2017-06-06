using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tabs : MonoBehaviour
{

    public Image essay;
    public Image email;
    public Image eee;
    public Image restart;
    public Image virusAlert;

    public int sceneNumber;

    // Use this for initialization
    void Start()
    {
        sceneNumber = 1;
        restart.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void updateEssay()
    {
        essay.enabled = true;
        email.enabled = false;
        eee.enabled = false;
    }

    public void updateEmail()
    {
        essay.enabled = false;
        email.enabled = true;
        eee.enabled = false;
    }

    public void updateEEE()
    {
        essay.enabled = false;
        email.enabled = false;
        eee.enabled = true;
    }

    public void uploadButtonOnClick()
    {
        if (sceneNumber == 1)
        {
            essay.enabled = false;
            email.enabled = false;
            eee.enabled = false;
            restart.enabled = true;
        }
    }
    public void virusButtonOnClick()
    {
        if (sceneNumber == 2 && virusAlert.enabled == true)
        {
            virusAlert.enabled = false;
        }
    }
}
