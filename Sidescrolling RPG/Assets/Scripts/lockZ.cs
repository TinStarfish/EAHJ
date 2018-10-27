using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockZ : MonoBehaviour {
	
	void FixedUpdate () {
        Vector3 pos = transform.position;
        pos.z = 0;
        transform.position = pos;

	}
}
