using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour {

    private GameObject InteractPanel;
    private Text InteractLabel;
    private Text ActionText;
    private float actionTextDisableTime = 3f;
    [Header("Interactable Attributes")]
    public string Name;
    public string actionTextString = "";

	void Start () {
        InteractPanel = GameObject.Find("InteractPanel");
       
        ActionText = GameObject.Find("ActionText").GetComponent<Text>();
        if(actionTextString=="")
        {
            actionTextString = "You interact with the " + Name;

        }


	}

    private void OnMouseEnter()
    {
        InteractPanel.SetActive(true);
        InteractLabel = InteractPanel.GetComponentInChildren<Text>();
        InteractLabel.text = Name;
        
       

    }
    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ActionText.text = actionTextString;
            StartCoroutine(disableActionText());
            OnInteraction();

        }
    }
    private void OnMouseExit()
    {
        InteractPanel.SetActive(false);

    }
    public virtual void OnInteraction()
    {
        

    }

    public IEnumerator disableActionText()
    {

        yield return new WaitForSeconds(actionTextDisableTime);
        ActionText.text = "";
    }

}
