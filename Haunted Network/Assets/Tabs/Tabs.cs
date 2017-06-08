using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tabs : MonoBehaviour
{

    public Image essay;
    public Image email;
    public Image eee;
    public Image restart;
    public Image virusAlert;
    public Image[] error;
    public Image[] ad;
    public Button[] adButtons;
    public Button virusButton;
    public Button onYourOwnButton;
    public Image onYourOwn;

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
        if (sceneNumber == 1)
        {
            essay.enabled = true;
            email.enabled = false;
            eee.enabled = false;
        }
    }

    public void updateEmail()
    {
        if (sceneNumber == 1)
        {
            essay.enabled = false;
            email.enabled = true;
            eee.enabled = false;
        }
    }

    public void updateEEE()
    {
        if (sceneNumber == 1)
        {
            essay.enabled = false;
            email.enabled = false;
            eee.enabled = true;
        }
    }

    public void uploadButtonOnClick()
    {
        if (sceneNumber == 1)
        {
            essay.enabled = false;
            email.enabled = false;
            eee.enabled = false;
            restart.enabled = true;
            virusButton.enabled = true;
            virusButton.image.enabled = true;
        }
    }
    public void virusButtonOnClick()
    {
        if (sceneNumber == 2 && virusAlert.enabled == true)
        {
            virusAlert.enabled = false;
            virusButton.enabled = false;
            virusButton.image.enabled = false;
            ad[0].enabled = true;
            ad[1].enabled = true;
            adButtons[0].enabled = true;
            adButtons[0].image.enabled = true;
            adButtons[1].enabled = true;
            adButtons[1].image.enabled = true;
        }
    }
    
    public void adClose0()
    {
        ad[0].enabled = false;
        adButtons[0].enabled = false;
        adButtons[0].image.enabled = false;
        adPopUp2();
    }

    public void adClose1()
    {
        ad[1].enabled = false;
        adButtons[1].enabled = false;
        adButtons[1].image.enabled = false;
        adPopUp2();
    }

    public void adClose2()
    {
        ad[2].enabled = false;
        adButtons[2].enabled = false;
        adButtons[2].image.enabled = false;
        adPopUp3();
    }

    public void adClose3()
    {
        ad[3].enabled = false;
        adButtons[3].enabled = false;
        adButtons[3].image.enabled = false;
        adPopUp3();
    }

    public void adClose4()
    {
        ad[4].enabled = false;
        adButtons[4].enabled = false;
        adButtons[4].image.enabled = false;
        adPopUp3();
    }

    public void adClose5()
    {
        ad[5].enabled = false;
        adButtons[5].enabled = false;
        adButtons[5].image.enabled = false;
        adPopUp3();
    }

    public void adClose6()
    {
        ad[6].enabled = false;
        adButtons[6].enabled = false;
        adButtons[6].image.enabled = false;
        adPopUp4();
    }

    public void adClose7()
    {
        ad[7].enabled = false;
        adButtons[7].enabled = false;
        adButtons[7].image.enabled = false;
        adPopUp4();
    }

    public void adClose8()
    {
        ad[8].enabled = false;
        adButtons[8].enabled = false;
        adButtons[8].image.enabled = false;
        adPopUp4();
    }
    public void adClose9()
    {
        ad[9].enabled = false;
        adButtons[9].enabled = false;
        adButtons[9].image.enabled = false;
        adPopUp4();
    }
    public void adClose10()
    {
        ad[10].enabled = false;
        adButtons[10].enabled = false;
        adButtons[10].image.enabled = false;
        adPopUp4();
    }
    public void adClose11()
    {
        ad[11].enabled = false;
        adButtons[11].enabled = false;
        adButtons[11].image.enabled = false;
        adPopUp4();
    }
    public void adClose12()
    {
        ad[12].enabled = false;
        adButtons[12].enabled = false;
        adButtons[12].image.enabled = false;
        adPopUp4();
    }
    public void adClose13()
    {
        ad[13].enabled = false;
        adButtons[13].enabled = false;
        adButtons[13].image.enabled = false;
        adPopUp4();
    }

    public void adPopUp2()
    {
        if (ad[1].enabled == false && ad[0].enabled == false)
        {
            ad[2].enabled = true;
            adButtons[2].enabled = true;
            adButtons[2].image.enabled = true;
            ad[3].enabled = true;
            adButtons[3].enabled = true;
            adButtons[3].image.enabled = true;
            ad[4].enabled = true;
            adButtons[4].enabled = true;
            adButtons[4].image.enabled = true;
            ad[5].enabled = true;
            adButtons[5].enabled = true;
            adButtons[5].image.enabled = true;
        }
    }

    public void adPopUp3()
    {
        if (ad[2].enabled == false && ad[3].enabled == false && ad[4].enabled == false && ad[5].enabled == false)
        {
            ad[6].enabled = true;
            adButtons[6].enabled = true;
            adButtons[6].image.enabled = true;
            ad[7].enabled = true;
            adButtons[7].enabled = true;
            adButtons[7].image.enabled = true;
            ad[8].enabled = true;
            adButtons[8].enabled = true;
            adButtons[8].image.enabled = true;
            ad[9].enabled = true;
            adButtons[9].enabled = true;
            adButtons[9].image.enabled = true;
            ad[10].enabled = true;
            adButtons[10].enabled = true;
            adButtons[10].image.enabled = true;
            ad[11].enabled = true;
            adButtons[11].enabled = true;
            adButtons[11].image.enabled = true;
            ad[12].enabled = true;
            adButtons[12].enabled = true;
            adButtons[12].image.enabled = true;
            ad[13].enabled = true;
            adButtons[13].enabled = true;
            adButtons[13].image.enabled = true;
        }
    }

    public void adPopUp4()
    {
        if(ad[6].enabled == false && ad[7].enabled == false && ad[8].enabled == false && ad[9].enabled == false && ad[10].enabled == false && ad[11].enabled == false && ad[12].enabled == false && ad[13].enabled == false)
        {
            onYourOwn.enabled = true;
            onYourOwnButton.enabled = true;
            onYourOwnButton.image.enabled = true;
        }
    }

    public void youreOnYourOwn()
    {
        onYourOwn.enabled = false;
        SceneManager.LoadScene("Scene2");
    }
}
