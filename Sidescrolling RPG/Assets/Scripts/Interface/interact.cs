using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class interact : MonoBehaviour {

    public GameObject interactPanel;
    public Text actionText;
    public Text interactLabel;

    public string interactableName;

    public string interactionText;
   
    public GameObject DialogueBox;
    public Image dialogueImage;
    public Text textBox;
    public Text nameTag;

    public AudioSource soundEffect;

    public Item[] items;

    public DialogueTrigger trigger;
   
    public bool isDoor = false;
    public bool isHumanoid = false;
    public bool isChest = false;
    public bool isPortal = false;
	
	void Start () {
  
      

	}
	
	
	void Update () {
        
       
       


    }

    private void OnMouseOver()
    {

        interactPanel.SetActive(true);

        interactLabel.text = interactableName;
        if (Input.GetKeyDown(KeyCode.E))
        {
            actionText.text = interactionText;
            if(soundEffect!=null)
            {
                soundEffect.Play();
            }
            

            if (isDoor)
            {
                
                GameObject.Destroy(gameObject);
                interactPanel.SetActive(false);

            }
            if(isPortal)
            {
                SceneManager.LoadScene("Endscene");

            }
            if(isHumanoid)
            {
                Debug.Log("Interacted with the human");
                
                trigger.TriggerDialogue();

            }
            if (isChest)
            {
                for (int i = 0; i <= items.Length;i++)
                {
                    bool wasPickedUp = Inventory.instance.AddItem(items[i]);
                    if (wasPickedUp)
                    {
                        Inventory.instance.AddItem(items[i]);
                        Destroy(gameObject);
                        interactPanel.SetActive(false);

                    }
                }

                
              
               

            }

        }
       

    }

    private void OnMouseExit()
    {
        interactPanel.SetActive(false);
        
    }




}
