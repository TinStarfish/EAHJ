using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "New Consumable", menuName = "Inventory/Consumable")]
public class Consumable : Item {

    private Character pl;

    public bool restoresHealth = false;
    public bool restoresMagic = false;
    public bool restoresStamina = false;

    public int restoreHealthAmount = 0;
    public int restoreMagicAmount = 0;
    public int restoreStaminaAmount = 0;

    public override void UseItem()
    {
        pl = FindObjectOfType<Character>();

        //base.UseItem();
        if (restoresHealth)
        {

            pl.AddHealth(restoreHealthAmount);

        }
        if(restoresMagic)
        {
            pl.AddMagic(restoreMagicAmount);

        }
        if(restoresStamina)
        {
            pl.AddStamina(restoreStaminaAmount);

        }

        RemoveFromInventory();

    }




}
