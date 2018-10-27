using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Weapon")]
public class WeaponItem : Item {

    public int Damage;
    public int CrystalPower;
    public float Speed;
    public int MagicCost;
    private Weapon weapon;
    public float projectileSpeed;
    public GameObject weaponModel;

    public override void UseItem()
    {
        weapon = FindObjectOfType<Weapon>();
        if(weapon!=null)
        {
            weapon.weaponItem = this;

        }
        base.UseItem();


    }

}
