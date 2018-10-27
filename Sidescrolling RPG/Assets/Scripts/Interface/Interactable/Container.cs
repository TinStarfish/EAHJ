using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : Interactable {
    [Header("Container Attributes")]
    public Item[] items;

    public override void OnInteraction()
    {
        for (int i = 0; i < items.Length; i++)
        {
            bool wasPickedUp = Inventory.instance.AddItem(items[i]);
            if (wasPickedUp)
            {
                Inventory.instance.AddItem(items[i]);
                Destroy(gameObject);
                

            }
        }


    }
}
