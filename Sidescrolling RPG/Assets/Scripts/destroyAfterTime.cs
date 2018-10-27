using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyAfterTime : MonoBehaviour {

    public float time = 2f;
    public GameObject impactEffect;

	void Start () {

        Destroy(gameObject, time);

	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag!="Enemy")
        {
            GameObject effectInstance = Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(effectInstance,1f);
        }

    }

}
