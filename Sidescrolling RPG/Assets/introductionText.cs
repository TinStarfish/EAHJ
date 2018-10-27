using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class introductionText : MonoBehaviour {

    private string[] sentences;

    public string intro1;
    public string intro2;
    public string intro3;
    public string intro4;
    public string intro5;

    public Text textbox;
    public int index = 0;

    public GameObject intro;
    public GameObject license;


	void Start () {
        if(intro1==null && intro2==null && intro3==null && intro4==null && intro5==null)
        {
            intro1 = "Explorers of Midlend have recently discovered a new country, across the seas.";
            intro2 = "This NEULEND holds many secrets, and YOU have been sent to investigate them.";
            intro3 = "YOU are an EXPEDITIONIST, an EXPLORER, a HERO.";
            intro4 = "Your JOURNEY,\nYour EXPEDITION,\nis about to begin.";
            intro5 = "But first, tell me a little about yourself.";

        }
		

        sentences = new string[5];
        sentences[0] = intro1;
        sentences[1] = intro2;
        sentences[2] = intro3;
        sentences[3] = intro4;
        sentences[4] = intro5;

        license.SetActive(false);

        StartCoroutine(TypeSentence("Welcome to the world of TOTH, a land ruled by MAGIC."));

         


    }

    void Update () {
		
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if (index < sentences.Length)
            {
                NextSentence(index);
                index++;

            } else
            {
                intro.SetActive(false);
                license.SetActive(true);
            }
           

        }
            

        

	}

    void NextSentence(int currentindex)
    {
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentences[currentindex]));
    

    }

    IEnumerator TypeSentence(string sentence)
    {
        textbox.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            textbox.text += letter;
            yield return 1;

        }

    }

}
