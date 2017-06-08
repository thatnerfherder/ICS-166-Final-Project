using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene3Tabs : MonoBehaviour
{
    public Image essay;
    public Image email;
    public Image eee;
    public Image ArabicEssay;
    public Image GreekEssay;
    public Image JapaneseEssay;
    public Image KoreanEssay;
    public Image SpanishEssay;
    public Image SwedishEssay;
    public Image FrenchEssay;
    public Text Passwordrequest;
    public InputField PasswordBox;
    public Image PasswordField;
    public Text PasswordText;
    public Button SubmitButton;
    public Image SubmitButtonImage;
    public Text SubmitButtonText;

    public bool isEnglishEssay = false;

    public Image Languages;
    public int languagenumber;
    public int sceneNumber;

    // Use this for initialization
    void Start()
    {
        sceneNumber = 3;
        Passwordrequest.enabled = false;
        PasswordBox.enabled = false;
        PasswordField.enabled = false;
        PasswordText.enabled = false;
        languagenumber = 1;
        SubmitButton.enabled = false;
        SubmitButtonImage.enabled = false;
        SubmitButtonText.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void updateEssay()
    {
        if (sceneNumber == 3)
        {
            email.enabled = false;
            eee.enabled = false;
            Languages.enabled = true;
            Passwordrequest.enabled = false;
            PasswordField.enabled = false;
            PasswordText.enabled = false;
            SubmitButton.enabled = false;
            SubmitButtonImage.enabled = false;
            SubmitButtonText.enabled = false;

            if (languagenumber == 0)
            {
                essay.enabled = true;
            }
            else if (languagenumber == 1)
            {
                KoreanEssay.enabled = true;
            }
            else if (languagenumber == 2)
            {
                GreekEssay.enabled = true;
            }
            else if (languagenumber == 3)
            {
                SpanishEssay.enabled = true;
            }
            else if (languagenumber == 4)
            {
                JapaneseEssay.enabled = true;
            }
            else if (languagenumber == 5)
            {
                SwedishEssay.enabled = true;
            }
            else if (languagenumber == 6)
            {
                ArabicEssay.enabled = true;
            }
            else if (languagenumber == 7)
            {
                FrenchEssay.enabled = true;
            }

        }
    }

    public void updateEmail()
    {
        if (sceneNumber == 3)
        {
            essay.enabled = false;
            email.enabled = true;
            eee.enabled = false;
            Languages.enabled = false;
            Passwordrequest.enabled = false;
            PasswordField.enabled = false;
            PasswordText.enabled = false;
            KoreanEssay.enabled = false;
            GreekEssay.enabled = false;
            JapaneseEssay.enabled = false;
            SpanishEssay.enabled = false;
            SwedishEssay.enabled = false;
            ArabicEssay.enabled = false;
            FrenchEssay.enabled = false;
            SubmitButton.enabled = false;
            SubmitButtonImage.enabled = false;
            SubmitButtonText.enabled = false;
        }
    }

    public void updateEEE()
    {
        if (sceneNumber == 3)
        {
            email.enabled = false;
            eee.enabled = true;
            Languages.enabled = false;
            KoreanEssay.enabled = false;
            GreekEssay.enabled = false;
            JapaneseEssay.enabled = false;
            SpanishEssay.enabled = false;
            SwedishEssay.enabled = false;
            ArabicEssay.enabled = false;
            FrenchEssay.enabled = false;
        }
    }

    public void uploadButtonOnClick()
    {
        if (sceneNumber == 3)
        {
            if (isEnglishEssay == true)
            {
                Passwordrequest.enabled = true;
                PasswordField.enabled = true;
                PasswordBox.enabled = true;
                PasswordText.enabled = true;
                SubmitButton.enabled = true;
                SubmitButtonImage.enabled = true;
                SubmitButtonText.enabled = true;
            }
            else
            {

            }
            
        }
    }

    public void submitButtonOnClick()
    {
        if (PasswordBox.text == "Normandy")
        {
            essay.enabled = false;
            email.enabled = false;
            eee.enabled = false;
            Languages.enabled = false;
            KoreanEssay.enabled = false;
            GreekEssay.enabled = false;
            JapaneseEssay.enabled = false;
            KoreanEssay.enabled = false;
            SpanishEssay.enabled = false;
            SwedishEssay.enabled = false;
            ArabicEssay.enabled = false;
            FrenchEssay.enabled = false;
            isEnglishEssay = false;
            SubmitButton.enabled = false;
            SubmitButtonImage.enabled = false;
            SubmitButtonText.enabled = false;
            Passwordrequest.enabled = false;
            PasswordField.enabled = false;
            PasswordText.enabled = false;

            //GO TO GAME OVER SCREEN?
        }
    }


    public void KoreanButtonOnClick()
    {
        if (sceneNumber == 3)
        {
            essay.enabled = false;
            email.enabled = false;
            eee.enabled = false;
            Languages.enabled = true;
            GreekEssay.enabled = false;
            JapaneseEssay.enabled = false;
            KoreanEssay.enabled = true;
            SpanishEssay.enabled = false;
            SwedishEssay.enabled = false;
            ArabicEssay.enabled = false;
            FrenchEssay.enabled = false;
            isEnglishEssay = false;
            languagenumber = 1;
        }
    }
    public void GreekButtonOnClick()
    {
        if (sceneNumber == 3)
        {
            essay.enabled = false;
            email.enabled = false;
            eee.enabled = false;
            Languages.enabled = true;
            KoreanEssay.enabled = false;
            GreekEssay.enabled = true;
            JapaneseEssay.enabled = false;
            KoreanEssay.enabled = false;
            SpanishEssay.enabled = false;
            SwedishEssay.enabled = false;
            ArabicEssay.enabled = false;
            FrenchEssay.enabled = false;
            isEnglishEssay = false;
            languagenumber = 2;

        }
    }
    public void SpanishButtonOnClick()
    {
        if (sceneNumber == 3)
        {
            essay.enabled = false;
            email.enabled = false;
            eee.enabled = false;
            Languages.enabled = true;
            KoreanEssay.enabled = false;
            GreekEssay.enabled = false;
            JapaneseEssay.enabled = false;
            KoreanEssay.enabled = false;
            SpanishEssay.enabled = true;
            SwedishEssay.enabled = false;
            ArabicEssay.enabled = false;
            FrenchEssay.enabled = false;
            isEnglishEssay = false;
            languagenumber = 3;

        }
    }
    public void JapaneseButtonOnClick()
    {
        if (sceneNumber == 3)
        {
            essay.enabled = false;
            email.enabled = false;
            eee.enabled = false;
            Languages.enabled = true;
            KoreanEssay.enabled = false;
            GreekEssay.enabled = false;
            JapaneseEssay.enabled = true;
            KoreanEssay.enabled = false;
            SpanishEssay.enabled = false;
            SwedishEssay.enabled = false;
            ArabicEssay.enabled = false;
            FrenchEssay.enabled = false;
            isEnglishEssay = false;
            languagenumber = 4;

        }
    }
    public void EnglishButtonOnClick()
    {
        if (sceneNumber == 3)
        {
            essay.enabled = true;
            email.enabled = false;
            eee.enabled = false;
            Languages.enabled = true;
            KoreanEssay.enabled = false;
            GreekEssay.enabled = false;
            JapaneseEssay.enabled = false;
            KoreanEssay.enabled = false;
            SpanishEssay.enabled = false;
            SwedishEssay.enabled = false;
            ArabicEssay.enabled = false;
            FrenchEssay.enabled = false;
            isEnglishEssay = true;
            languagenumber = 0;

        }
    }
    public void SwedishButtonOnClick()
    {
        if (sceneNumber == 3)
        {
            essay.enabled = false;
            email.enabled = false;
            eee.enabled = false;
            Languages.enabled = true;
            KoreanEssay.enabled = false;
            GreekEssay.enabled = false;
            JapaneseEssay.enabled = false;
            KoreanEssay.enabled = false;
            SpanishEssay.enabled = false;
            SwedishEssay.enabled = true;
            ArabicEssay.enabled = false;
            FrenchEssay.enabled = false;
            isEnglishEssay = false;
            languagenumber = 5;


        }
    }
    public void ArabicButtonOnClick()
    {
        if (sceneNumber == 3)
        {
            essay.enabled = false;
            email.enabled = false;
            eee.enabled = false;
            Languages.enabled = true;
            KoreanEssay.enabled = false;
            GreekEssay.enabled = false;
            JapaneseEssay.enabled = false;
            KoreanEssay.enabled = false;
            SpanishEssay.enabled = false;
            SwedishEssay.enabled = false;
            ArabicEssay.enabled = true;
            FrenchEssay.enabled = false;
            isEnglishEssay = false;
            languagenumber = 6;

        }
    }
    public void FrenchButtonOnClick()
    {
        if (sceneNumber == 3)
        {
            essay.enabled = false;
            email.enabled = false;
            eee.enabled = false;
            Languages.enabled = true;
            KoreanEssay.enabled = false;
            GreekEssay.enabled = false;
            JapaneseEssay.enabled = false;
            KoreanEssay.enabled = false;
            SpanishEssay.enabled = false;
            SwedishEssay.enabled = false;
            ArabicEssay.enabled = false;
            FrenchEssay.enabled = true;
            isEnglishEssay = false;
            languagenumber = 7;

        }
    }
}
