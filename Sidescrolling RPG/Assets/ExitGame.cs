using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour {

	public void ClickToExit()
    {
        Debug.Log("Closing Application");
        Application.Quit();

    }

}
