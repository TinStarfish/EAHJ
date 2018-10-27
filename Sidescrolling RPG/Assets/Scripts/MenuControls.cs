using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuControls : MonoBehaviour {

    //Key Shortcuts
    public KeyCode pause;
    public KeyCode stats;
    public KeyCode inventory;

    //GUI
    public GameObject Pause;
    public GameObject Stats;
    public GameObject Inventory;
    public GameObject Gui;

    void Start () {
        defaultKeyCodes();

	}

    void defaultKeyCodes()
    {
       
        pause = KeyCode.Tab;
        stats = KeyCode.C;
        inventory = KeyCode.B;


    }
	
	
	void Update () {

        if (Input.GetKeyDown(pause))
        {
            if(Pause.activeInHierarchy)
            {
                ExitMenu();

            } else
            {
                OpenPause();

            }
            

        }
        if (Input.GetKeyDown(stats))
        {
            OpenPause();
            ChangeToStatistics();

        }
        if (Input.GetKeyDown(inventory))
        {
            OpenPause();
            ChangeToInventory();

        }


    }

    void OpenPause()
    {
        Pause.SetActive(true);

    }

    void ChangeToInventory()
    {
        Stats.SetActive(false);
        Inventory.SetActive(true);


    }

    void ChangeToStatistics()
    {
        Stats.SetActive(true);
        Inventory.SetActive(false);

    }

    void ExitMenu()
    {
        Pause.SetActive(false);
        Inventory.SetActive(false);
        Stats.SetActive(false);
        Gui.SetActive(true);

    }

}
