using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTextToCharacterName : MonoBehaviour {

    public Character playerCharacter;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Text>().text = playerCharacter.getName();
    }

    void OnChange()
    {
       

    }

}
