using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject {

    public new string name;
    public Sprite icon = null;
    public bool isDefaultItem = false;
    
    private int id;
    private float quality;
    private string effectsList;
    private string description;


    public virtual void UseItem()
    {
        


    }

    public void RemoveFromInventory()
    {
        Inventory.instance.RemoveItem(this);


    }

}
