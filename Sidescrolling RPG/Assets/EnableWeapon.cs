using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableWeapon : MonoBehaviour {



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("Weapon").GetComponentInChildren<Weapon>().GetGameObjectComponent().SetActive(true);

        }

    }

}
