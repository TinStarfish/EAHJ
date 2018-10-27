using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInformation : MonoBehaviour {

    public Character player;

    public Text playerName;
    public Text playerClass;
    public Text playerRace;
    public Text playerTitle;
    public Text playerLevel;
    public Text playerPowerLevel;

    public Text BrawnText;
    public Text VitalityText;
    public Text ReflexText;
    public Text WitsText;
    public Text CharmText;
    public Text CautionText;


    void Start()
    {
      
        fillText();



    }

    private void Update()
    {
        fillText();
    }

    void fillText()
    {
        playerName.text = "Name: "+player.getName();
        playerClass.text = "Class: " + player.getClass();
        playerRace.text = "Race: " + player.getRace();
        playerTitle.text = "Title: " + player.getTitle();
        playerLevel.text = "Level: " + player.getLevel().ToString();
        playerPowerLevel.text = "Power Lv: "+ player.getPowerLevel().ToString();
        BrawnText.text = player.getBrawn().ToString();
        VitalityText.text = player.getVitality().ToString();
        ReflexText.text = player.getReflex().ToString();
        WitsText.text = player.getWits().ToString();
        CharmText.text = player.getCharm().ToString();
        CautionText.text = player.getCaution().ToString();


    }
	
	
}
