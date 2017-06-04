using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tabs : MonoBehaviour {

    public Image essay;
    public Image email;
    public Image eee;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
}
