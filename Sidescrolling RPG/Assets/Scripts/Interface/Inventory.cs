using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    public Character player;

    public List<Item> items = new List<Item>();

    

    //Slots
    public int carryingCapacity = 32;
    public Transform itemsParent;
    public InventorySlot[] slots;

    //Inspection Tool
    public Text itemName;
    public Text itemDesc;
    public Text itemQuality;
    public Text itemEffects;


    #region Singleton
    public static Inventory instance;

    private void Awake()
    {
        if(instance!=null)
        {
            
            Debug.LogWarning("Too many inventories");
            return;

        }

        instance = this;

    }

    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;


    void Start () {

        defaultInventory();

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();


	}

    void defaultInventory()
    {
        
       
        
       

    }

    public bool AddItem(Item itemToAdd)
    {
        if (!itemToAdd.isDefaultItem)
        {
            if (items.Count >= carryingCapacity)
            {
                Debug.Log("Not enough room.");
                return false;

            }
            items.Add(itemToAdd);

            if(onItemChangedCallback!=null)
                onItemChangedCallback.Invoke();

        }

        return true;
       
    }

    public void RemoveItem(Item itemToRemove)
    {
       
        items.Remove(itemToRemove);
        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();

    }


    public void updateInspector(string slotName)
    {
        


    


    }


}
