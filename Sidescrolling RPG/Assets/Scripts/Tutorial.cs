using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {

    public bool tutorialIsActive = true;
    public GameObject tutorial;

    public void ToggleTutorials()
    {
        if(tutorialIsActive)
        {
            tutorialIsActive = false;
            tutorial.SetActive(false);
        } else
        {
            tutorialIsActive = true;
            tutorial.SetActive(true);
        }

    }
}
