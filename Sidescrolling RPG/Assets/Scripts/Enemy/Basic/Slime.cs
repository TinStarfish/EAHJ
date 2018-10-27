using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour {

    //Attributes
    public string name;
    public float health;
    public float maxHealth;
    public float damage;

    //Game Object
    public GameObject slime;

	void Start () {

        maxHealth = Random.Range(0, 10);
        health = maxHealth;


    }
	
	
	void Update () {
		
	}
}
