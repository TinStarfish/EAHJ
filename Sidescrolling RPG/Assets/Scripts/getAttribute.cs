using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getAttribute : MonoBehaviour {

    public GameObject CharacterController;
    private Character player;

    //interface
    public Text PlayerName;
    public Text PlayerTitle;
    public Text Health_no;
    public Text Magic_no;
    public Text Brawn_no;
    public Text Vitality_no;
    public Text Reflex_no;
    public Text Wits_no;
    public Text Charm_no;
    public Text Caution_no;
    public Text Level_no;
    

	void Start () {


        player = CharacterController.GetComponent<Character>();
        assignValuesFromPlayer();

	}
	
	void Update () {
		
	}
    private void assignValuesFromPlayer()
    {
        PlayerName.text = player.getName();
        PlayerTitle.text = player.getTitle();
        Health_no.text = ""+player.getHealth();
        Magic_no.text = "" + player.getMagic();
        Brawn_no.text = "" + player.getBrawn();
        Vitality_no.text = "" + player.getVitality();
        Reflex_no.text = "" + player.getReflex();
        Wits_no.text = "" + player.getWits();
        Charm_no.text = "" + player.getCharm();
        Caution_no.text = "" + player.getCaution();
        Level_no.text = "" + player.getLevel();
        
    }
}
