using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TabsScene2 : MonoBehaviour
{

    public Image essay;
    public Image[] email;
    public Image[] eee;
    public Image restart;
    public Image[] error;
    public Image[] ad;
    public Button[] adButtons;
    public Button reply;
    public Button send;
    public Image[] redacted;
    public Button[] redactedButtons;
    public Button upload;

    public bool emailSent;
    public bool adBlockOn;
    public bool replyEmail;
    public bool sendEmail;
    public bool turnAdBlockOn;
    public bool essayFine;

    int emailTimer;
    int adBlockTimer;

    // Use this for initialization
    void Start()
    {
        restart.enabled = false;
        emailSent = false;
        adBlockOn = false;
        sendEmail = false;
        turnAdBlockOn = false;
        essayFine = false;
        emailTimer = 0;
        adBlockTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (replyEmail == true && emailSent == false)
        {
            reply.image.enabled = false;
            reply.enabled = false;
            if(emailTimer < 60)
            {
                emailTimer++;
                email[0].enabled = false;
                email[1].enabled = true;
            }
            else if(emailTimer < 120)
            {
                emailTimer++;
                email[1].enabled = false;
                email[2].enabled = true;
            }
            else if (emailTimer < 180)
            {
                emailTimer++;
                email[2].enabled = false;
                email[3].enabled = true;
            }
            else if (emailTimer < 240)
            {
                emailTimer++;
                email[3].enabled = false;
                email[4].enabled = true;
                send.image.enabled = true;
                send.enabled = true;
                replyEmail = false;
            }
        }
        if(sendEmail == true && emailSent == false)
        {
            if(emailTimer < 300)
            {
                emailTimer++;
                email[4].enabled = false;
                email[5].enabled = true;
            }
            else if(emailTimer < 360)
            {
                emailTimer++;
                email[5].enabled = false;
                email[6].enabled = true;
                send.image.enabled = false;
                send.enabled = false;
                sendEmail = false;
                emailSent = true;
            }
        }
        if (turnAdBlockOn && !adBlockOn)
        {
            if (adBlockTimer < 200)
            {
                adBlockTimer++;
                eee[0].enabled = false;
                eee[1].enabled = true;
            }
            else if (adBlockTimer < 400)
            {
                adBlockTimer++;
                eee[1].enabled = false;
                eee[2].enabled = true;
                adBlockOn = true;
                turnAdBlockOn = false;
                for (int i = 0; i < ad.Length; i++)
                {
                    ad[i].enabled = false;
                    adButtons[i].enabled = false;
                    adButtons[i].image.enabled = false;
                    upload.image.enabled = true;
                    upload.enabled = true;
                }
            }
        }

    }

    public void updateEssay()
    {
        if (emailSent == false)
        {
            email[0].enabled = false;
        }
        else
        {
            email[6].enabled = false;
        }
        if(adBlockOn == false)
        {
            eee[0].enabled = false;
        }
        else
        {
            eee[2].enabled = false;
        }
        if (!essayFine)
        {
            for(int i = 0; i < redacted.Length; i++)
            {
                redacted[i].enabled = true;
                redactedButtons[i].image.enabled = true;
                redactedButtons[i].enabled = true;
            }
        }
        for (int i = 0; i < ad.Length; i++)
        {
            ad[i].enabled = false;
            adButtons[i].enabled = false;
            adButtons[i].image.enabled = false;
        }
        essay.enabled = true;
        reply.image.enabled = false;
        reply.enabled = false;
        upload.image.enabled = false;
        upload.enabled = false;

    }

    public void updateEmail()
    {
        if (emailSent == false)
        {
            email[0].enabled = true;
            reply.image.enabled = true;
            reply.enabled = true;
        }
        else
        {
            email[6].enabled = true;
        }
        if (adBlockOn == false)
        {
            eee[0].enabled = false;
        }
        else
        {
            eee[2].enabled = false;
        }
        if (!essayFine)
        {
            for (int i = 0; i < redacted.Length; i++)
            {
                redacted[i].enabled = false;
                redactedButtons[i].image.enabled = false;
                redactedButtons[i].enabled = false;
            }
        }
        for (int i = 0; i < ad.Length; i++)
        {
            ad[i].enabled = false;
            adButtons[i].enabled = false;
            adButtons[i].image.enabled = false;
        }
        essay.enabled = false;
        upload.image.enabled = false;
        upload.enabled = false;
    }

    public void updateEEE()
    {
        if (emailSent == false)
        {
            email[0].enabled = false;
        }
        else
        {
            email[6].enabled = false;
        }
        if (adBlockOn == false)
        {
            eee[0].enabled = true;
        }
        else
        {
            eee[2].enabled = true;
        }
        if (!essayFine)
        {
            for (int i = 0; i < redacted.Length; i++)
            {
                redacted[i].enabled = false;
                redactedButtons[i].image.enabled = false;
                redactedButtons[i].enabled = false;
            }
        }
        essay.enabled = false;
        reply.image.enabled = false;
        reply.enabled = false;
        upload.image.enabled = true;
        upload.enabled = true;
    }

    public void redacted0()
    {
        redacted[0].enabled = false;
        redactedButtons[0].image.enabled = false;
        redactedButtons[0].enabled = false;
        if(redactedButtons[0].enabled == false && redactedButtons[1].enabled == false && redactedButtons[2].enabled == false && redactedButtons[3].enabled == false && redactedButtons[4].enabled == false)
        {
            essayFine = true;
        }
    }

    public void redacted1()
    {
        redacted[1].enabled = false;
        redactedButtons[1].image.enabled = false;
        redactedButtons[1].enabled = false;
        if (redactedButtons[0].enabled == false && redactedButtons[1].enabled == false && redactedButtons[2].enabled == false && redactedButtons[3].enabled == false && redactedButtons[4].enabled == false)
        {
            essayFine = true;
        }
    }

    public void redacted2()
    {
        redacted[2].enabled = false;
        redactedButtons[2].image.enabled = false;
        redactedButtons[2].enabled = false;
        if (redactedButtons[0].enabled == false && redactedButtons[1].enabled == false && redactedButtons[2].enabled == false && redactedButtons[3].enabled == false && redactedButtons[4].enabled == false)
        {
            essayFine = true;
        }
    }

    public void redacted3()
    {
        redacted[3].enabled = false;
        redactedButtons[3].image.enabled = false;
        redactedButtons[3].enabled = false;
        if (redactedButtons[0].enabled == false && redactedButtons[1].enabled == false && redactedButtons[2].enabled == false && redactedButtons[3].enabled == false && redactedButtons[4].enabled == false)
        {
            essayFine = true;
        }
    }

    public void redacted4()
    {
        redacted[4].enabled = false;
        redactedButtons[4].image.enabled = false;
        redactedButtons[4].enabled = false;
        if (redactedButtons[0].enabled == false && redactedButtons[1].enabled == false && redactedButtons[2].enabled == false && redactedButtons[3].enabled == false && redactedButtons[4].enabled == false)
        {
            essayFine = true;
        }
    }

    public void uploadButtonOnClick()
    {
        Debug.Log("made it into the upload function");
        if (!adBlockOn)
        {
            ad[0].enabled = true;
            adButtons[0].enabled = true;
            adButtons[0].image.enabled = true;
            ad[1].enabled = true;
            adButtons[1].enabled = true;
            adButtons[1].image.enabled = true;
            upload.enabled = false;
            upload.image.enabled = false;
        }
        if(adBlockOn && emailSent && essayFine)
        {
            Debug.Log("should be restarting");
            restart.enabled = true;
            eee[2].enabled = false;
        }
    }

    public void replyToProf()
    {
        if(emailSent == false)
            replyEmail = true;
    }

    public void sendToProf()
    {
        if (emailSent == false)
            sendEmail = true;
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
        reUpload();
    }

    public void adClose7()
    {
        ad[7].enabled = false;
        adButtons[7].enabled = false;
        adButtons[7].image.enabled = false;
        reUpload();
    }

    public void adClose8()
    {
        ad[8].enabled = false;
        adButtons[8].enabled = false;
        adButtons[8].image.enabled = false;
        reUpload();
    }
    public void adClose9()
    {
        ad[9].enabled = false;
        adButtons[9].enabled = false;
        adButtons[9].image.enabled = false;
        reUpload();
    }
    public void adClose10()
    {
        ad[10].enabled = false;
        adButtons[10].enabled = false;
        adButtons[10].image.enabled = false;
        reUpload();
    }
    public void adClose11()
    {
        ad[11].enabled = false;
        adButtons[11].enabled = false;
        adButtons[11].image.enabled = false;
        reUpload();
    }
    public void adClose12()
    {
        ad[12].enabled = false;
        adButtons[12].enabled = false;
        adButtons[12].image.enabled = false;
        reUpload();
    }
    public void adClose13()
    {
        ad[13].enabled = false;
        adButtons[13].enabled = false;
        adButtons[13].image.enabled = false;
        reUpload();
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
    public void reUpload()
    {
        if (ad[6].enabled == false && ad[7].enabled == false && ad[8].enabled == false && ad[9].enabled == false && ad[10].enabled == false && ad[11].enabled == false && ad[12].enabled == false && ad[13].enabled == false)
        {
            if (!adBlockOn)
            {
                ad[0].enabled = true;
                adButtons[0].enabled = true;
                adButtons[0].image.enabled = true;
                ad[1].enabled = true;
                adButtons[1].enabled = true;
                adButtons[1].image.enabled = true;
                upload.enabled = false;
                upload.image.enabled = false;
            }
        }
    }

    public void adBlock()
    {
        if (!adBlockOn)
        {
            turnAdBlockOn = true;
            upload.enabled = true;
            upload.image.enabled = true;
        }
    }
}
