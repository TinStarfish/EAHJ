using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : MonoBehaviour {

    public Vector3 rotation;
    public float minRotation = -90f;
    public float maxRotation = 180f;

	void Update () {

        if (gameObject.transform.rotation.z <= minRotation)
        {
            gameObject.transform.Rotate(0, 0, -4);
        }
        else if (gameObject.transform.rotation.z >= maxRotation)
        {
            gameObject.transform.Rotate(0, 0, 4);

        }


        Swing();

       

	}

    void Swing()
    {
      

    }
}
