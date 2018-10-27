using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public GameObject GUI;
    public GameObject Inventory;
    public GameObject Pause;

    public Weapon weapon;

	void Awake () {
        //Inventory.SetActive(true);
        GUI.SetActive(true);
        weapon = FindObjectOfType<Weapon>();


	}

    private void Start()
    {
        Inventory.SetActive(false);
    }

    void Update () {
		
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if(Inventory.activeInHierarchy)
            {
                Inventory.SetActive(false);
                weapon.isPaused = false;
                GUI.SetActive(true);
                Time.timeScale = 1f;

            } else
            {
                GUI.SetActive(false);
                Inventory.SetActive(true);
                weapon.isPaused = true;
                Time.timeScale = 0f;

            }

        }
        

	}
}
