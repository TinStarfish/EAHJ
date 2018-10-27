using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPictureToClass : MonoBehaviour {

    public Image PlayerImage;
    public Character playerCharacter;
    public Dropdown selector;

    public Sprite cavalier;
    public Sprite magus;
    public Sprite vagrant;

    void Start () {
		
	}
	
	void Update () {

        if (selector.value == 0)
        {
            playerCharacter.SetClass("cavalier");
        }
        if (selector.value == 1)
        {
            playerCharacter.SetClass("magus");
        }
        if (selector.value == 2)
        {
            playerCharacter.SetClass("vagrant");
        }




        if (playerCharacter.getClass().Equals("cavalier"))
        {
            PlayerImage.sprite = cavalier;

        }
        if (playerCharacter.getClass().Equals("magus"))
        {
            PlayerImage.sprite = magus;

        }
        if (playerCharacter.getClass().Equals("vagrant"))
        {
            PlayerImage.sprite = vagrant;

        }


    }
}
