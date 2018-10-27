using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoDamage : MonoBehaviour {

    private int damage;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetDamage(int _damage)
    {
        damage = _damage;

    }

    public int GetDamage()
    {
        return damage;

    }

   
}
