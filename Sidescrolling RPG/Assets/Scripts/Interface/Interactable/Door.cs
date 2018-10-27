using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable {
    [Header("Door Attributes")]
    public GameObject rotatePoint;
    public float amountToRotate = 90f;
    public bool isOpen = false;
    

    public override void OnInteraction()
    {
        if(isOpen)
        {
            rotatePoint.transform.Rotate(0, -amountToRotate, 0);
            isOpen = false;

        } else
        {
            rotatePoint.transform.Rotate(0, amountToRotate, 0);
            isOpen = true;
        }
      

    }

}
