using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPictureToRace : MonoBehaviour {

    public Image PlayerImage;
    public Character playerCharacter;
    public Dropdown selector;


    public Sprite human;
    public Sprite elf;
    public Sprite orc;

	void Start () {
		
	}
	
	
	void Update () {
        if (selector.value == 0)
        {
            playerCharacter.SetRace("human");
        }
        if (selector.value == 1)
        {
            playerCharacter.SetRace("orc");
        }
        if (selector.value == 2)
        {
            playerCharacter.SetRace("elf");
        }




        if (playerCharacter.getRace().Equals("human"))
        {
            PlayerImage.sprite = human;

        }
        if (playerCharacter.getRace().Equals("elf"))
        {
            PlayerImage.sprite = elf;

        }
        if (playerCharacter.getRace().Equals("orc"))
        {
            PlayerImage.sprite = orc;

        }



    }
}
