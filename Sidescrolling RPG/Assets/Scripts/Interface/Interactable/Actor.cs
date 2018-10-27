using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : Interactable {

    [Header("Actor Attributes")]
    public DialogueTrigger trigger;

    public override void OnInteraction()
    {
        trigger.TriggerDialogue();

    }
}
